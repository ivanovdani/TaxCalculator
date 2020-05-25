using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TestTaxCalculator
    {
        [TestMethod]
        public void TestGetNet()
        {
            Dictionary<decimal, decimal> pairs = new Dictionary<decimal, decimal>
            {
                {3400, 2860},
                {980, 980 },
                {2700, 2275 }
            };
            decimal net;

            foreach (KeyValuePair<decimal, decimal> pair in pairs)
            {
                net = TaxCalculator.TaxCalculator.GetNet(pair.Key);
                Assert.AreEqual(pair.Value, net);
            }
            
        }
    }
}
