namespace UnitTest.DFS
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.DFS.DistanceK;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DistanceKTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var n = TreeNode.GetTreeNode(3, 5, 1, 6, 2, 0, 8, null, null, 7, 4);
            var t = new TreeNode(5);
            var k = 2;
            Solution.DistanceK(n, t, k).Should().Equal(7, 4, 1);
        }

        [TestMethod]
        public void Test2()
        {
            var n = TreeNode.GetTreeNode(0, 1, null, 3, 2);
            var t = new TreeNode(2);
            var k = 1;
            Solution.DistanceK(n, t, k).Should().Equal(1);
        }

        [TestMethod]
        public void Test3()
        {
            var n = TreeNode.GetTreeNode(0, 1, null, 3, 2);
            var t = new TreeNode(2);
            var k = 2;
            Solution.DistanceK(n, t, k).Should().Equal(3, 0);
        }

        [TestMethod]
        public void Test4()
        {
            var n = TreeNode.GetTreeNode(0, 1, null, 3, 2);
            var t = new TreeNode(2);
            var k = 0;
            Solution.DistanceK(n, t, k).Should().Equal(2);
        }
    }
}
