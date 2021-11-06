namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CanJumpTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.CanJump(2, 3, 1, 1, 4).Should().BeTrue();
        }


        [TestMethod]
        public void Test2()
        {
            Solution.CanJump(3, 2, 1, 0, 4).Should().BeFalse();
        }
    }
}
