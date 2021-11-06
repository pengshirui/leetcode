namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FlattenTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l1 = TreeNode.GetTreeNode(1, 2, 5, 3, 4, null, 6);
            var r1 = TreeNode.GetTreeNode(1, null, 2, null, 3, null, 4, null, 5, null, 6);
            _solution.Flatten(l1);
            l1.Should().BeEquivalentTo(r1);
        }
    }
}
