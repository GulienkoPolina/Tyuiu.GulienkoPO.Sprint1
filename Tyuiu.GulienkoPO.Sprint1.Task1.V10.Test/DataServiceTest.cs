using Tyuiu.GulienkoPO.Sprint1.Task1.V10.Lib;

namespace Tyuiu.GulienkoPO.Sprint1.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}