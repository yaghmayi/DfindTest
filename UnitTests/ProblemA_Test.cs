using DfindTest.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DfindTest.UnitTests
{
    [TestClass]
    public class ProblemA_Test
    {
        [TestMethod]
        public void GetPNorm_Test()
        {
            Assert.AreEqual(1.4142135624, ProblemA.GetPNorm(1.0, 1.0, 2.0, 2.0, 2.0));
            Assert.AreEqual(2.0000000000, ProblemA.GetPNorm(1.0, 1.0, 2.0, 2.0, 1.0));
            Assert.AreEqual(20.3636957882, ProblemA.GetPNorm(1.0, 1.0, 20.0, 20.0, 10.0));
        }
    }
}
