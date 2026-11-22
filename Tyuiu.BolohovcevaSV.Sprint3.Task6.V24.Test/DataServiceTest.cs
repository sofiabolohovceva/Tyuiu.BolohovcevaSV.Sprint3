using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint3.Task6.V24.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopvalue = 26;

            int res = ds.GetSumTheDivisors(startValue, stopvalue);

            int wait = 41;

            Assert.AreEqual(wait, res);
        }
    }
}
