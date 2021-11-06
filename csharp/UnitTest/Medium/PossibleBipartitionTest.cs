namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.PossibleBipartition;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PossibleBipartitionTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var n = 3;
            var dis = new int[][]
            {
                new int[] {1, 2},
                new int[] {1, 3},
                new int[] {2, 3},
            };
            Solution.PossibleBipartition(n, dis).Should().BeFalse();
        }

        [TestMethod]
        public void Test2()
        {
            var n = 4;
            var dis = new int[][]
            {
                new int[] {1, 2},
                new int[] {1, 3},
                new int[] {2, 4},
            };
            Solution.PossibleBipartition(n, dis).Should().BeTrue();
        }
    }
}
