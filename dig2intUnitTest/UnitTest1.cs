using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberTranslateLibrary;
using System;

namespace dig2intUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Необходимые переменые
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";   //Алфавит систем счисления
            char k = '0';                                                   //символ

            int expected=digits.IndexOf(k);                                 //Ожидаемый результат
            int result = ClassTranslate.dig2int(k);                         //Результат

            Assert.AreEqual(expected, result);                              //Проверка 
            


        }
    }
}
