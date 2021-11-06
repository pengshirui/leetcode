namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Easy.DiameterOfBinaryTree;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DiameterOfBinaryTreeTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var t1 = TreeNode.GetTreeNode(1, 2, 3, 4, 5);
            Solution.DiameterOfBinaryTree(t1).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var t2 = TreeNode.GetTreeNode(1, 2);
            Solution.DiameterOfBinaryTree(t2).Should().Be(1);
        }
    }
}
