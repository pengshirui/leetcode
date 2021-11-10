namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class QTest
    {
        [TestMethod]
        public void Test1()
        {
            var q = new Q(3);
            q.Enqueue(1);
            q.Peek().Should().Be(1);
            q.Enqueue(2);
            q.Peek().Should().Be(1);
            q.Enqueue(3);
            q.Peek().Should().Be(1);
            q.Enqueue(4);
            q.Peek().Should().Be(2);
            q.Enqueue(5);
            q.Peek().Should().Be(3);
            q.Dequeue().Should().Be(3);
            q.Peek().Should().Be(4);
            q.Enqueue(6);
            q.Peek().Should().Be(4);
        }

        [TestMethod]
        public void Test2()
        {
            var q = new Q(1);
            q.Enqueue(1);
            q.Peek().Should().Be(1);
            q.Enqueue(2);
            q.Peek().Should().Be(2);
            q.Enqueue(3);
            q.Peek().Should().Be(3);
            q.Enqueue(4);
            q.Peek().Should().Be(4);
            q.Enqueue(5);
            q.Peek().Should().Be(5);
            q.Dequeue().Should().Be(5);
            q.Enqueue(6);
            q.Peek().Should().Be(6);
        }
    }
}
