namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium.LongestConsecutive;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestConsecutiveTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var tree = TreeNode.GetTreeNode(1, null, 3, 2, 4, null, null, null, 5);
            Solution.LongestConsecutive(tree).Should().Be(3);
        }
    }
}
