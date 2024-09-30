using Tyuiu.GulienkoPO.Sprint1.Task4.V17.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.GulienkoPO.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 11;
            double y = 2;
            double wait = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}