namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AddTwoNumbersTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l1 = ListNode.GetListNode(2, 4, 3);
            var l2 = ListNode.GetListNode(5, 6, 4);
            var r1 = ListNode.GetListNode(7, 0, 8);

            Solution.AddTwoNumbers(l1, l2).Should().BeEquivalentTo(r1);
        }

        [TestMethod]
        public void Test2()
        {
            var l3 = ListNode.GetListNode(0);
            var l4 = ListNode.GetListNode(0);
            var r2 = ListNode.GetListNode(0);

            Solution.AddTwoNumbers(l3, l4).Should().BeEquivalentTo(r2);
        }

        [TestMethod]
        public void Test3()
        {
            var l5 = ListNode.GetListNode(9, 9, 9, 9, 9, 9, 9);
            var l6 = ListNode.GetListNode(9, 9, 9, 9);
            var r3 = ListNode.GetListNode(8, 9, 9, 9, 0, 0, 0, 1);

            Solution.AddTwoNumbers(l5, l6).Should().BeEquivalentTo(r3);
        }

        [TestMethod]
        public void Test4()
        {
            var l1 = ListNode.GetListNode(2, 4, 3);
            var l2 = ListNode.GetListNode(5, 6, 4);
            var r1 = ListNode.GetListNode(7, 0, 8);

            Solution.AddTwoNumbersRecursive(l1, l2).Should().BeEquivalentTo(r1);
        }

        [TestMethod]
        public void Test5()
        {
            var l3 = ListNode.GetListNode(0);
            var l4 = ListNode.GetListNode(0);
            var r2 = ListNode.GetListNode(0);

            Solution.AddTwoNumbersRecursive(l3, l4).Should().BeEquivalentTo(r2);
        }

        [TestMethod]
        public void Test6()
        {
            var l5 = ListNode.GetListNode(9, 9, 9, 9, 9, 9, 9);
            var l6 = ListNode.GetListNode(9, 9, 9, 9);
            var r3 = ListNode.GetListNode(8, 9, 9, 9, 0, 0, 0, 1);

            Solution.AddTwoNumbersRecursive(l5, l6).Should().BeEquivalentTo(r3);
        }
    }
}
