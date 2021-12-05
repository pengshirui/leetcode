namespace UnitTest.Tree
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Tree.Rob;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RobTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var t = TreeNode.GetTreeNode(41, 37, 44, 24, 39, 42, 48, 1, 35, 38, 40, null, 43, 46, 49, 0, 2, 30, 36, null, null, null, null, null, null, 45, 47, null, null, null, null, null, 4, 29, 32, null, null, null, null, null, null, 3, 9, 26, null, 31, 34, null, null, 7, 11, 25, 27, null, null, 33, null, 6, 8, 10, 16, null, null, null, 28, null, null, 5, null, null, null, null, null, 15, 19, null, null, null, null, 12, null, 18, 20, null, 13, 17, null, null, 22, null, 14, null, null, 21, 23);
            Solution.Rob(t).Should().Be(690);
        }
    }
}
