namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TreeToDoublyListTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var node1 = TreeNode.GetTreeNode(4, 2, 5, 1, 3);

            var r1 = Solution.TreeToDoublyList(node1);
            r1.val.Should().Be(1);
            r1.right.val.Should().Be(2);
            r1.left.val.Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            var node1 = TreeNode.GetTreeNode(1);
            var r1 = Solution.TreeToDoublyList(node1);
            var r2 = Solution.TreeToDoublyList(null);

            r1.right.Should().Be(r1);
            r1.left.Should().Be(r1);
            r2.Should().BeNull();
        }
    }
}
