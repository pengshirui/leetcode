namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxPathSumTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var t = TreeNode.GetTreeNode(-10, 9, 20, null, null, 15, 7);
            Solution.MaxPathSum(t).Should().Be(42);
        }

        [TestMethod]
        public void Test2()
        {
            var t = TreeNode.GetTreeNode(-10);
            Solution.MaxPathSum(t).Should().Be(-10);
        }

        [TestMethod]
        public void Test3()
        {
            var t = TreeNode.GetTreeNode(10);
            Solution.MaxPathSum(t).Should().Be(10);
        }

        [TestMethod]
        public void Test4()
        {
            var t = TreeNode.GetTreeNode(5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1);
            Solution.MaxPathSum(t).Should().Be(48);
        }
    }
}
