namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindRedundantConnection2Test
    {
        private readonly Solution solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g1 = new int[3][]
            {
                new int[]{ 1, 2 },
                new int[]{ 1, 3 },
                new int[]{ 2, 3 },
            };
            var r1 = new int[] { 2, 3 };
            solution.FindRedundantConnection2(g1).Should().BeEquivalentTo(r1);

            var g2 = new int[5][]
            {
                new int[]{ 2, 1 },
                new int[]{ 3, 2 },
                new int[]{ 4, 3 },
                new int[]{ 1, 4 },
                new int[]{ 1, 5 },
            };
            var r2 = new int[] { 1, 4 };
            solution.FindRedundantConnection2(g2).Should().BeEquivalentTo(r2);
        }
    }
}
