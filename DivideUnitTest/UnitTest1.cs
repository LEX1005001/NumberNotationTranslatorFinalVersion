using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberTranslateLibrary;
using System;

namespace DivideUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "1,34";                          //Само число

            string[]expected =s.Split(',');             //Ожидаемый результат 10 5
            string[]result = ClassTranslate.Divide(s);// Результат

            Assert.AreEqual(expected[0], result[0]);    //Проверяет == ли [0] значения обоих массивов
            Assert.AreEqual(expected[1], result[1]);    //Проверяет == ли [1] значения обоих массивов

        }
    }
}
