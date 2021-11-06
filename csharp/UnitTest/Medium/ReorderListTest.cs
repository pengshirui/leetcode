namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReorderListTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l1 = ListNode.GetListNode(1, 2, 3, 4);
            var r1 = ListNode.GetListNode(1, 4, 2, 3);
            Solution.ReorderList(l1);
            l1.Should().BeEquivalentTo(r1);
        }

        [TestMethod]
        public void Test2()
        {
            var l2 = ListNode.GetListNode(1, 2, 3, 4, 5);
            var r2 = ListNode.GetListNode(1, 5, 2, 4, 3);
            Solution.ReorderList(l2);
            l2.Should().BeEquivalentTo(r2);
        }
    }
}
