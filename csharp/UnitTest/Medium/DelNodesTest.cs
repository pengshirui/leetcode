namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium.DelNodes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DelNodesTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var root = TreeNode.GetTreeNode(1, 2, 3, 4, 5, 6, 7);
            var to_delete = new int[] { 3, 5 };
            var r = Solution.DelNodes(root, to_delete);
            r[0].val.Should().Be(1);
            r[1].val.Should().Be(6);
            r[2].val.Should().Be(7);
        }
    }
}
