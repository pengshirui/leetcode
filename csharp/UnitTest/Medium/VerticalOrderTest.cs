namespace UnitTest.Medium
{
    using System.Collections.Generic;
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class VerticalOrderTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var node = TreeNode.GetTreeNode(3, 9, 20, null, null, 15, 7);
            var expected = new List<IList<int>>
            {
                new List<int> { 9 },
                new List<int> { 3, 15 },
                new List<int> { 20 },
                new List<int> { 7 },
            };
            var result = Solution.VerticalOrder(node);
            for (var i = 0; i < expected.Count; i++)
            {
                result[i].Should().Equal(expected[i]);
            }
        }

        [TestMethod]
        public void Test2()
        {
            var node = TreeNode.GetTreeNode(3, 9, 8, 4, 0, 1, 7, null, null, null, 2, 5);
            var expected = new List<IList<int>>
            {
                new List<int> { 4 },
                new List<int> { 9, 5 },
                new List<int> { 3, 0 ,1 },
                new List<int> { 8, 2 },
                new List<int> { 7 },
            };
            var result = Solution.VerticalOrder(node);
            for (var i = 0; i < expected.Count; i++)
            {
                result[i].Should().Equal(expected[i]);
            }

        }
    }
}
