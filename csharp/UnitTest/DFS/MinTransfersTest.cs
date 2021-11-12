namespace UnitTest.DFS
{
    using FluentAssertions;
    using LeetCode.DFS.MinTransfers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinTransfersTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[][] t = { new int[]{ 0, 1, 10 }, new int[] { 2, 0, 5 } };
            Solution.MinTransfers(t).Should().Be(2);
        }
    }
}
