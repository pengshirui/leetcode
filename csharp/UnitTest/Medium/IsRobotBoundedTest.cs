namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.IsRobotBounded;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsRobotBoundedTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s1 = "GGLLGG";

            Solution.IsRobotBounded(s1).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var s1 = "GG";

            Solution.IsRobotBounded(s1).Should().BeFalse();
        }

        [TestMethod]
        public void Test3()
        {
            var s1 = "GLRLLGLL";

            Solution.IsRobotBounded(s1).Should().BeTrue();
        }
    }
}
