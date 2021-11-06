namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.OddEvenJumps;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OddEvenJumpsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var num = new int[] { 10, 13, 12, 14, 15 };
            Solution.OddEvenJumps(num).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var num = new int[] { 1, 2, 3, 2, 1, 4, 4, 5 };
            Solution.OddEvenJumps(num).Should().Be(6);
        }

        [TestMethod]
        public void Test3()
        {
            var num = new int[] { 84 };
            Solution.OddEvenJumps(num).Should().Be(1);
        }

        [TestMethod]
        public void Test4()
        {
            var num = new int[] { 81, 54, 96, 60, 58 };
            Solution.OddEvenJumps(num).Should().Be(2);
        }
    }
}
