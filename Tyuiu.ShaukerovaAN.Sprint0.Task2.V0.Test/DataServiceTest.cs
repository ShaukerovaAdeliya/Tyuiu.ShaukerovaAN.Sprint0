using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ShaukerovaAN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Adeliya";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEquel
            Assert.AreEqual("Hello, Adeliya", res);
        }
    }
}
