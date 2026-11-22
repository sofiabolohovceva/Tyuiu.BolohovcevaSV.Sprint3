using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint3.Task7.V20.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] wait = new double[]
            {
                17.27,
                14.08,
                10.27,
                6.65,
                3.87,
                2.00,
                -0.74,
                -3.71,
                -7.59,
                -11.55,
                -14.74
            };

            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
