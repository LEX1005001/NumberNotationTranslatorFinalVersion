using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberTranslateLibrary;
using System;

namespace notation10_IntUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x = "13,5";     //целая часть числа
            int P = 4;          //система счисления

            int x10 = ClassTranslate.dig2int(x[0]); 
            for (int i = 1; i < x.Length; i++)
            {
                x10 *= P;
                x10 += ClassTranslate.dig2int(x[i]);
            }

            string expected =Convert.ToString(x10);                 //Ожидаемый результат
            string result = ClassTranslate.notation10_Int(x, P);    //Результат

            Assert.AreEqual(expected, result);                      //Проверка
        }
    }
}
