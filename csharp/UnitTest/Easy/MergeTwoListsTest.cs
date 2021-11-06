namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MergeTwoListsTest
    {
        Solution solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l1 = ListNode.GetListNode(1, 2, 4);
            var l2 = ListNode.GetListNode(1, 3, 4);
            var r1 = this.solution.MergeTwoLists(l1, l2);
            var exp1 = ListNode.GetListNode(1, 1, 2, 3, 4, 4);
            r1.Should().BeEquivalentTo(exp1);

            var l3 = ListNode.GetListNode();
            var l4 = ListNode.GetListNode();
            var r2 = this.solution.MergeTwoLists(l3, l4);
            var exp2 = ListNode.GetListNode();
            r2.Should().BeEquivalentTo(exp2);

            var l5 = ListNode.GetListNode();
            var l6 = ListNode.GetListNode(1);
            var r3 = this.solution.MergeTwoLists(l5, l6);
            var exp3 = ListNode.GetListNode(1);
            r3.Should().BeEquivalentTo(exp3);
        }

    }
}
