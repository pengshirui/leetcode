namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FlipEquivTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l1 = TreeNode.GetTreeNode(1, 2, 3, 4, 5, 6, null, null, null, 7, 8);
            var l2 = TreeNode.GetTreeNode(1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7);
            Solution.FlipEquiv(l1, l2).Should().BeTrue();
        }
    }
}
