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

        //Оператор сложения с вызовом через оператор +
        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.x + b.x, a.y + b.y);
        }
        public static MyComplex Sub(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.x - b.x, a.y - b.y);
        }
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.x - b.x, a.y - b.y);
        }

        public static MyComplex Div(MyComplex a, double d)
        {
            if (d == 0) throw new Exception("Divide by zero");
            var tmp = new MyComplex();
            tmp.x = a.x / d;
            tmp.y = a.y / d;
            return tmp;
        }

        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.x * b.x - a.y * b.y, a.x * b.y + a.y * b.x);
        }

        public static MyComplex operator *(MyComplex a, double d)
        {
            return new MyComplex(a.x * d, a.y * d);
        }

        public static MyComplex Conj(MyComplex a)
        {
            return new MyComplex(a.x, -a.y);
        }

        public static MyComplex ScalarDot(MyComplex a, MyComplex b)
        {
            return a * Conj(b);
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

        #region Properties

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Norm
        {
            get { return this.Abs(); }
        }

        #endregion

    }
}
