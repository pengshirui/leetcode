namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.CalculateMinimumHP;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CalculateMinimumHPTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[][] d =
            {
                new int[] { -2, -3, 3 },
                new int[] { -5, -10, 1 },
                new int[] { 10, 30, -5 },
            };
            Solution.CalculateMinimumHP(d).Should().Be(7);
        }
    }
}
