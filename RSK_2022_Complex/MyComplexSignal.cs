using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSK_2022_Complex
{
    public class MyComplexSignal
    {
        #region Fields
        public List<MyComplex> data = new List<MyComplex>();
        public double norm = 0;
        public MyComplex location = new MyComplex();
        #endregion
        #region Constructors

        public MyComplexSignal()
        { }
        public MyComplexSignal(double[] X, double[] Y)
        {
            data = new List<MyComplex>(X.Length);
            for (int i = 0; i < X.Length; i++)
            {
                data.Add(new MyComplex(X[i], Y[i]));
            }
            GetNorm();
        }
        #endregion
        #region Methods
        public double GetNorm()
        {
            double norm = 0;
            foreach (var v in data)
            {
                norm += v.Abs();
            }
            norm = data.Count > 0 ? norm / data.Count : 0;
            this.norm = norm;
            return norm;
        }
        public int Normalize()
        {
            if (data.Count == 0) return 1;
            double coeff = GetNorm();
            coeff = coeff == 0 ? 0 : 1 / coeff;
            for (int i = 0; i < data.Count; i++)
            {
                data[i] = data[i] * coeff;
            }
            return 0;
        }

        public static MyComplexSignal Scale(MyComplexSignal a, double scale)
        {
            var res = new MyComplexSignal();
            int count = a.data.Count;
            res.data = new List<MyComplex>(count);
            for (int i = 0; i < count; i++)
            {
                res.data.Add(new MyComplex(a.data[i].x * scale, a.data[i].y * scale));
            }
            res.GetNorm();
            return res;
        }
        //Rotate
        public static MyComplexSignal Rotate(MyComplexSignal a, double angle)
        {
            var res = new MyComplexSignal();
            int count = a.data.Count;
            MyComplex r = new MyComplex(Math.Cos(angle), Math.Sin(angle));
            res.data = new List<MyComplex>(count);
            for (int i = 0; i < count; i++)
            {
                res.data.Add(a.data[i] * r);
            }
            res.GetNorm();
            return res;
        }
        public static MyComplexSignal Move(MyComplexSignal a, MyComplex shift)
        {
            var res = new MyComplexSignal();
            int count = a.data.Count;
            res.data = new List<MyComplex>(count);
            res.location = a.location + shift;
            for (int i = 0; i < count; i++)
            {
                res.data.Add(a.data[i]);
            }
            res.GetNorm();
            return res;
        }

        public static MyComplexSignal Conjugate(MyComplexSignal a)
        {
            var res = new MyComplexSignal();
            int count = a.data.Count;
            res.data = new List<MyComplex>(count);
            for (int i = 0; i < count; i++)
            {
                res.data.Add(new MyComplex(a.data[i].x, -a.data[i].y));
            }
            res.GetNorm();
            return res;
        }

        public static MyComplexSignal MathAction(MyComplexSignal a, MyComplexSignal b,
        Func<MyComplex, MyComplex, MyComplex> func)
        {
            var res = new MyComplexSignal();
            int count = a.data.Count < b.data.Count ? a.data.Count : b.data.Count;
            res.data = new List<MyComplex>(count);
            for (int i = 0; i < count; i++)
            {
                var tmp = func(a.data[i], b.data[i]);
                res.data.Add(tmp);
            }
            res.GetNorm();
            return res;
        }
        public static MyComplex Scalar(MyComplexSignal a, MyComplexSignal b)
        {
            var temp = MathAction(a, b, MyComplex.ScalarDot);
            var sum = new MyComplex(0, 0);
            foreach (var t in temp.data)
            {
                sum = sum + t;
            }
            return sum;
        }

        public static MyComplexSignal Mult(MyComplexSignal a, MyComplexSignal b)
        {
            return MathAction(a, b, (x, y) => x * y);
        }
        public static MyComplexSignal Sum(MyComplexSignal a, MyComplexSignal b)
        {
            return MathAction(a, b, (x, y) => x + y);
        }
        public static MyComplexSignal Sub(MyComplexSignal a, MyComplexSignal b)
        {
            return MathAction(a, b, (x, y) => x - y);
        }
        #endregion
    }
}
