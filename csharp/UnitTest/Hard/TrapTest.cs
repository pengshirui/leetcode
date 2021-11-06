namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.Trap;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TrapTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.Trap(0, 1, 1, 0).Should().Be(0);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.Trap(1, 0, 0, 1).Should().Be(2);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.Trap(3, 1, 0, 2).Should().Be(3);
        }

        [TestMethod]
        public void Test4()
        {
            Solution.Trap(3, 1, 2, 3).Should().Be(3);
        }

        [TestMethod]
        public void Test5()
        {
            Solution.Trap(0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1).Should().Be(6);
        }
    }
}
