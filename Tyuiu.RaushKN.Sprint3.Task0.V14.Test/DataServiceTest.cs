using Tyuiu.RaushKN.Sprint3.Task0.V14.Lib;

namespace Tyuiu.RaushKN.Sprint3.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            int wait = 14400;

            Assert.AreEqual(wait, res);
        }
    }
}