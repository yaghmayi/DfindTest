using DfindTest.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DfindTest.UnitTests
{
    [TestClass]
    public class ProblemB_Test
    {
        [TestMethod]
        public void GetRemovingCandlesCount_Test()
        {
            Assert.AreEqual(4, ProblemB.GetRemovingCandlesCount(2, 26, 8));
        }
    }
}
