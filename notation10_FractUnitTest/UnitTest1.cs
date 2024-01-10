using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberTranslateLibrary;
using System;
using System.Linq;

namespace notation10_FractUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x = "42";//дробная часть числа
            int P = 4;      //Cистема счисления

            string xZero = "0" + x;
            char[] xReverse = xZero.ToCharArray().Reverse().ToArray();

            double x10 = ClassTranslate.dig2int(xReverse[0]);
            for (int i = 1; i < xReverse.Length; i++)
            {
                x10 /= P;
                x10 += ClassTranslate.dig2int(xReverse[i]);
            }
            string tmp = Convert.ToString(x10);

            string expected = tmp.Substring(2, tmp.Length - 2);
            string result = ClassTranslate.notation10_Fract(x, P);

            Assert.AreEqual(expected, result);
        }
    }
}
