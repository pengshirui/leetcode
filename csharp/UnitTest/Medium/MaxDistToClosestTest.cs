namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MaxDistToClosest;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxDistToClosestTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.MaxDistToClosest(1, 0, 0, 0, 1, 0, 1).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.MaxDistToClosest(1, 0, 0, 0).Should().Be(3);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.MaxDistToClosest(0, 1).Should().Be(1);
        }

        [TestMethod]
        public void Test4()
        {
            Solution.MaxDistToClosest(0, 0, 1).Should().Be(2);
        }
    }
}
