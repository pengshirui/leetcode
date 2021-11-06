namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsValidBSTTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var n1 = TreeNode.GetTreeNode(5, 4, 6, null, null, 3, 7);

            Solution.IsValidBST(n1).Should().BeFalse();
        }

        [TestMethod]
        public void Test2()
        {
            var n2 = TreeNode.GetTreeNode(2, 2, 2);

            Solution.IsValidBST(n2).Should().BeFalse();
        }

        [TestMethod]
        public void Test3()
        {
            var n3 = TreeNode.GetTreeNode(2, 1, 3);

            Solution.IsValidBST(n3).Should().BeTrue();
        }

        [TestMethod]
        public void Test4()
        {
            var n4 = TreeNode.GetTreeNode(int.MaxValue);

            Solution.IsValidBST(n4).Should().BeTrue();
        }
    }
}
