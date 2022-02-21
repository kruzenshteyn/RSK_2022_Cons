using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSK_2022_Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                MyComplex a = new MyComplex(4, 2);
                var d = 0;

                double[] arr = new double[10];

                Console.WriteLine("a = " + a.ToString());
                Console.WriteLine("d = " + arr[9].ToString());

                var c = MyComplex.Div(a, d);
                Console.WriteLine("c = " + c.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());                
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
