using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GnidenkoPA.Sprint3.Task5.V24.Lib;

namespace Tyuiu.GnidenkoPA.Sprint3.Task5.V24.Test
{
    [TestClass]
    public class Sprint3Task5V24Test
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            Sprint3Task5V24 ds = new Sprint3Task5V24();
            int x = 2;
            int startI = 1;
            int stopI = 3;
            int startK = 1;
            int stopK = 12;

            // Правильное ожидаемое значение (округлённое до тысячных)
            double expected = -12926.893;

            double result = ds.GetSumSumSeries(x, startI, startK, stopI, stopK);

            // Проверка с допуском, учитывающим погрешность округления
            Assert.AreEqual(expected, result, 0.0001, "Результат после округления не соответствует ожидаемому.");
        }
    }
}