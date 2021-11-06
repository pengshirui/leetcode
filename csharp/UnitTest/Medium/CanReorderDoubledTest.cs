namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.CanReorderDoubled;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CanReorderDoubledTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.CanReorderDoubled(3, 1, 3, 6).Should().BeFalse();
        }

        [TestMethod]
        public void Test2()
        {
            Solution.CanReorderDoubled(4, -2, 2, -4).Should().BeTrue();
        }

        [TestMethod]
        public void Test3()
        {
            Solution.CanReorderDoubled(2, 1, 2, 1, 1, 1, 2, 2).Should().BeTrue();
        }

        [TestMethod]
        public void Test4()
        {
            Solution.CanReorderDoubled(1, 2, 1, -8, 8, -4, 4, -4, 2, -2).Should().BeTrue();
        }
    }
}
