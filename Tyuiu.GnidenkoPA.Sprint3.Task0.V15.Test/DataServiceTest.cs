using Tyuiu.GnidenkoPA.Sprint3.Task0.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint3.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateSum()
        {
            DataService ds = new DataService();
            double t = 0.7;
            double wait = 4.7932; 
            double result = ds.DistanceOverTime(0, 0, 0, t);
            Assert.AreEqual(wait, result, 0.0001);
        }
    }
}
