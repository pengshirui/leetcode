namespace UnitTest.Easy
{
    using System;
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class InorderTraversalTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var t1 = TreeNode.GetTreeNode(1, null, 2, 3);

            _solution.InorderTraversal(t1).Should().BeEquivalentTo(new int[] { 1, 3, 2 });
        }

        [TestMethod]
        public void Test2()
        {
            var t2 = TreeNode.GetTreeNode();

            _solution.InorderTraversal(t2).Should().BeEquivalentTo(Array.Empty<int>());
        }

        [TestMethod]
        public void Test3()
        {
            var t3 = TreeNode.GetTreeNode(1);

            _solution.InorderTraversal(t3).Should().BeEquivalentTo(new int[] { 1 });
        }
    }
}
