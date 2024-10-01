using Tyuiu.GulienkoPO.Sprint1.Task7.V20.Lib;

namespace Tyuiu.GulienkoPO.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1, y = 2;
            var n = ds.Calculate(x, y);
            Assert.AreEqual(4.129, n);
        }
    }
}