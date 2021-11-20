namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.MinDifficulty;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinDifficultyTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[] j = { 6, 5, 4, 3, 2, 1 };
            var d = 2;
            Solution.MinDifficulty(j, d).Should().Be(7);
        }
    }
}
