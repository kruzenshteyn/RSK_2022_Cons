using RSK_2022_Complex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSK_2022_WFA_Complex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string str = $"X = {e.X} Y = {e.Y}";
            lblPos.Text = str;
        }

        async private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = $"Solving...";
                var ticks = Environment.TickCount;
               
                progressBar1.Value = 0;
                var progress = new Progress<int>(value => { progressBar1.Increment(value); });

                var res = await ProgressBarExample(progress);
                //Вычисление суммы прогрессии
                double sum = 0;
                foreach (var d in res)
                {
                    sum += d;
                }
                ticks = Environment.TickCount - ticks;

                label4.Text = $"Elapsed time = {ticks} ms";
            }
            catch(Exception ex)
            {
                tbResult.Text = "Error";
                MessageBox.Show(ex.ToString());
            }
        }

        async public static Task<double[]> ProgressBarExample(IProgress<int> progress)
        {
            var res = new double[100];
            Task task = Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    res[i - 1] = i;
                    Thread.Sleep(50);
                    if (progress != null)
                        progress.Report(1);
                }
            });
            await task;
            return res;
        }


        async public static Task<double[]> ProgressBarExampleParallel(IProgress<int> progress)
        {
            Random rnd = new Random();
            var res = new double[100];
            Task task = Task.Factory.StartNew(() =>
            {
                Parallel.For(1, 101, (i) =>
                {
                    res[i - 1] = i;
                    Thread.Sleep((int)(rnd.NextDouble() * 30 + 100));
                    if (progress != null)
                        progress.Report(1);
                });
            });
            await task;
            return res;
        }


        private static void ParalleExample(Progress<int> progress)
        {
            int count = 100;

            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(100);
                //if (progress != null)
                    //progress.Report(i);
            }

            //Parallel.For(0, count, (i) =>
            //{
            //    Thread.Sleep(100);

            //});
        }

        private void tbReal_TextChanged(object sender, EventArgs e)
        {
            var tb = (sender as TextBox);
            
            string valid = "0123456789i+-*.,/ ";
            
            bool isOk = true;
            foreach(var s in tb.Text)
            {
                //if (!valid.Contains(s)) isOk = false;
                isOk = valid.Contains(s) ? isOk : false;
            }

            lblTest.Text = "";
            if (!isOk) lblTest.Text = "Есть недопустимый символ";
        }

        private void tbReal_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        MyComplexSignal signal = new MyComplexSignal();

        private void btnGenArray_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int count = 10;

            signal.data.Clear();

            for (int i = 0; i < count; i++)
            {
                var x = Math.Truncate(rnd.NextDouble() * 100);
                var y = Math.Truncate(rnd.NextDouble() * 100);
                signal.data.Add(new MyComplex(x, y));
            }

            dataGridView1.DataSource = signal.data;
        }

        private void GenDoubleArray()
        {
            Random rnd = new Random();

            int count = 10;

            List<double> arr = new List<double>(count);

            var str = "";

            for (int i = 0; i < count; i++)
            {
                var d = Math.Truncate(rnd.NextDouble() * 100);
                arr.Add(d);
                str += d.ToString() + "\t";
            }
            str += "\n";

            //Sort
            arr.Sort((x, y) => y.CompareTo(x));

            foreach (var d in arr)
            {
                str += d.ToString() + "\t";
            }
            richTextBox1.Text = str;
        }
    }
}
