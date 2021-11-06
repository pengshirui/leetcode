namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DiffWaysToComputeTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.DiffWaysToCompute("2-1-1").Should().BeEquivalentTo(0, 2);
        }

        [TestMethod]
        public void Test2()
        {
            _solution.DiffWaysToCompute("2*3-4*5").Should().BeEquivalentTo(-34, -14, -10, -10, 10);
        }
    }
}
