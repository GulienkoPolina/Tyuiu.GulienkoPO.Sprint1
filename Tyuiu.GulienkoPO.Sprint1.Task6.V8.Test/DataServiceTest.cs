using Tyuiu.GulienkoPO.Sprint1.Task6.V8.Lib;

namespace Tyuiu.GulienkoPO.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "123";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "231";
            Assert.AreEqual(wait, res);
        }
    }
}