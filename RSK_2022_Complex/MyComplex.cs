using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSK_2022_Complex
{
    public class MyComplex
    {
        #region Fields

        public double x = 0;
        public double y = 0;

        #endregion

        #region Constructors

        public MyComplex() { }

        public MyComplex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Methods

        public static MyComplex Add(MyComplex a, MyComplex b)
        {
            var res = new MyComplex();
            res.x = a.x + b.x;
            res.y = a.y + b.y;

            return res;
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.x + b.x, a.y + b.y);
        }

        public static MyComplex Div(MyComplex a, double d)
        {
            if (d == 0) throw new Exception("Divide by zero");
            var tmp = new MyComplex();
            tmp.x = a.x / d;
            tmp.y = a.y / d;
            return tmp;
        }

        public static MyComplex Mult(MyComplex a, MyComplex b)
        {



            return null;
        }

        public double Abs()
        {
            var res = x * x + y * y;
            return Math.Sqrt(res);
        }

        public override string ToString()
        {
            return $"{x} + {y} i";
        }

        #endregion

    }
}
