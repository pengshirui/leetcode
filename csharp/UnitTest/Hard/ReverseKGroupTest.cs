namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReverseKGroupTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var head = ListNode.GetListNode(1, 2, 3, 4, 5);
            var k = 2;
            var exp = ListNode.GetListNode(2, 1, 4, 3, 5);
            var r = _solution.ReverseKGroup(head, k);
            while (r != null)
            {
                r.val.Should().Be(exp.val);
                r = r.next;
                exp = exp.next;
            }
        }

        [TestMethod]
        public void Test2()
        {
            var head = ListNode.GetListNode(1, 2, 3, 4, 5);
            var k = 3;
            var exp = ListNode.GetListNode(3, 2, 1, 4, 5);
            var r = _solution.ReverseKGroup(head, k);
            while (r != null)
            {
                r.val.Should().Be(exp.val);
                r = r.next;
                exp = exp.next;
            }
        }
    }
}
