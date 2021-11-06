namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Easy.LowestCommonAncestor;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LowestCommonAncestorTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nodes = TreeNode.GetTreeNode(6, 2, 8, 0, 4, 7, 9, null, null, 3, 5);
            Solution.LowestCommonAncestor(nodes, new TreeNode(2), new TreeNode(4)).val.Should().Be(2);
        }
    }
}
