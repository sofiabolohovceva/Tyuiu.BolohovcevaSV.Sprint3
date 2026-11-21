using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint3.Task3.V9.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string value = "56hy vfe4r4 vf45b";
            char item = 'w';

            string res = ds.ReplaceNumOnChar(value, item);
            string wait = "wwhy vfewrw vfwwb";

            Assert.AreEqual(wait, res);
        }
    }
}
