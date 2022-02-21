using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using RSK_2022_Complex;

namespace UnitTest_Cons
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TM_ComplexAdd()
        {
            MyComplex a = new MyComplex(1, 2);
            var b = new MyComplex(3, 4);

            var c = MyComplex.Add(a, b);

            Assert.AreEqual(4, c.x, "Error in real part");
            Assert.AreEqual(6, c.y, "Error in image part");
        }

        [TestMethod]
        public void TM_ComplexOpAdd()
        {
            MyComplex a = new MyComplex(1, 2);
            var b = new MyComplex(3, 4);

            var c = a + b;

            Assert.AreEqual(4, c.x, "Error in real part");
            Assert.AreEqual(6, c.y, "Error in image part");
        }

        [TestMethod]
        public void TM_ComplexAbs()
        {
            var a = new MyComplex(3, 5);

            var actual = a.Abs();

            Assert.AreEqual(5.83, actual, 0.01);
        }

        [TestMethod]
        public void TM_ComplexDivD()
        {
            MyComplex a = new MyComplex(4, 2);
            var d = 2;

            var c = MyComplex.Div(a, d);

            Assert.AreEqual(2, c.x, "Error in real part");
            Assert.AreEqual(1, c.y, "Error in image part");
        }
    }
}
