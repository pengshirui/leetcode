namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.Jump;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class JumpTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.Jump(2, 3, 1, 1, 4).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.Jump(1).Should().Be(0);
        }

        [TestMethod]
        public void Test4()
        {
            Solution.Jump(2, 3, 0, 1, 4).Should().Be(2);
        }

        [TestMethod]
        public void Test5()
        {
            Solution.Jump(2, 1).Should().Be(1);
        }
    }
}
