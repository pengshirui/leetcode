namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class KVHeapTest
    {
        [TestMethod]
        public void Test1()
        {
            var heap = new KVHeap();
            heap.Add(1, 3);
            heap.Peek().Should().Be((1, 3));
            heap.Add(2, 2);
            heap.Peek().Should().Be((2, 2));
            heap.Add(5, 3);
            heap.Peek().Should().Be((2, 2));
            heap.Pop().Should().Be((2, 2));
            heap.Peek().Should().Be((1, 3));
            heap.Pop().Should().Be((1, 3));
            heap.Peek().Should().Be((5, 3));
        }
    }
}
