using Tyuiu.GulienkoPO.Sprint1.Task3.V5.Lib;

namespace Tyuiu.GulienkoPO.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3.5;
            double b = 120;
            double wait = 420;
            var res = ds.DistanceLength(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}