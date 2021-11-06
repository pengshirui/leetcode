namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Hard.ClosestKValues;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ClosestKValuesTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var tree = TreeNode.GetTreeNode(4, 2, 5, 1, 3);
            var target = 3.714286;
            var k = 2;
            Solution.ClosestKValues(tree, target, k).Should().Equal(3, 4);
        }
    }
}
