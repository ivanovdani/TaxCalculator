using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestTaxCalculator
    {
        [TestMethod]
        public void TestGetNet()
        {
            decimal gross = 3400;
            decimal expectedNet = 2860;
            decimal net = TaxCalculator.TaxCalculator.GetNet(gross);
            Assert.AreEqual(expectedNet, net);
        }
    }
}
