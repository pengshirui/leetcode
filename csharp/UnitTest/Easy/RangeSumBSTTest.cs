namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Easy.RangeSumBST;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RangeSumBSTTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var t = TreeNode.GetTreeNode(10, 5, 15, 3, 7, null, 18);
            Solution.RangeSumBST(t, 7, 15).Should().Be(32);
        }

    }
}
