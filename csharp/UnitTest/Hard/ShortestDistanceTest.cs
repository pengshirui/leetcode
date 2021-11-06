namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.ShortestDistance;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShortestDistanceTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g1 = new int[][]
            {
                new int[] { 1, 0, 2, 0, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
            };
            Solution.ShortestDistance(g1).Should().Be(7);
        }

        [TestMethod]
        public void Test2()
        {
            var g2 = new int[2][]
            {
                new int[] { 1,1 },
                new int[] { 1,0 },
            };
            Solution.ShortestDistance(g2).Should().Be(-1);
        }

        [TestMethod]
        public void Test3()
        {
            var g3 = new int[1][]
            {
                new int[] { 1 },
            };
            Solution.ShortestDistance(g3).Should().Be(-1);
        }
    }
}
