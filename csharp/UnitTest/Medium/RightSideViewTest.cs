namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RightSideViewTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l = TreeNode.GetTreeNode(1, 2, 3, 4);

            _solution.RightSideView(l).Should().Equal(1, 3, 4);
        }

        [TestMethod]
        public void Test2()
        {
            var l = TreeNode.GetTreeNode(1);

            _solution.RightSideView(l).Should().Equal(1);
        }
    }
}
