namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CompareVersionTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var v1 = "1.0.1";
            var v2 = "1";
            Solution.CompareVersion(v1, v2).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            var v1 = "1.0.0.0";
            var v2 = "1.0";
            Solution.CompareVersion(v1, v2).Should().Be(0);
        }

        [TestMethod]
        public void Test3()
        {
            var v1 = "1.01";
            var v2 = "1.1";
            Solution.CompareVersion(v1, v2).Should().Be(0);
        }

        [TestMethod]
        public void Test4()
        {
            var v1 = "1.001.0.5";
            var v2 = "1.1.0.5";
            Solution.CompareVersion(v1, v2).Should().Be(0);
        }
    }
}
