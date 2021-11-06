namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsSymmetricTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nodes = TreeNode.GetTreeNode(1, 2, 2, 3, 4, 4, 3);
            _solution.IsSymmetric(nodes).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var nodes = TreeNode.GetTreeNode(1, 2, 2, null, 3, null, 3);
            _solution.IsSymmetric(nodes).Should().BeFalse();
        }
    }
}
