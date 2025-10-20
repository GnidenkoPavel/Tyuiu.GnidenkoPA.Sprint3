using Tyuiu.GnidenkoPA.Sprint3.Task0.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint3.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;

            double wait = 4.7932; 
            double result = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(wait, result, 0.0001);
        }
    }
}
