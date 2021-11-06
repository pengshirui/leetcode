namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CanFinishTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var pre = new int[1][]
            {
                new int[] { 1, 0 },
            };

            Solution.CanFinish(2, pre).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var pre = new int[4][]
            {
                new int[] { 1, 4 },
                new int[] { 2, 4 },
                new int[] { 3, 1 },
                new int[] { 3, 2 },
            };
            Solution.CanFinish(5, pre).Should().BeTrue();
        }
    }
}
