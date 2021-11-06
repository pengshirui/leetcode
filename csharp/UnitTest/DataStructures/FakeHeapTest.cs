namespace UnitTest.DataStructures
{
    using System;
    using System.Collections.Generic;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FakeHeapTest
    {
        [TestMethod]
        public void Test1()
        {
            var heap = new FakeHeap();
            var rnd = new Random();
            for (var i = 0; i < 100000; i++)
            {
                heap.Push(rnd.Next(int.MinValue, int.MaxValue));
            }
            /*
            var first = heap.Pop();
            for (var i = 1; i < heap.Count(); i++)
            {
                var val = heap.Pop();
                first.Should().BeLessOrEqualTo(val);
            }
            */
        }

        [TestMethod]
        public void Test2()
        {
            var heap = new FakeHeap();
            var rnd = new Random();
            for (var i = 0; i < 100000; i++)
            {
                heap.Push2(rnd.Next(int.MinValue, int.MaxValue));
            }
            /*
            var first = heap.Pop();
            for (var i = 1; i < heap.Count(); i++)
            {
                var val = heap.Pop();
                first.Should().BeLessOrEqualTo(val);
            }
            */
        }

        [TestMethod]
        public void Test3()
        {
            var list = new List<int>();
            var rnd = new Random();
            for (var i = 0; i < 100000; i++)
            {
                list.Add(rnd.Next(int.MinValue, int.MaxValue));
            }
            /*
            var first = heap.Pop();
            for (var i = 1; i < heap.Count(); i++)
            {
                var val = heap.Pop();
                first.Should().BeLessOrEqualTo(val);
            }
            */
        }

        [TestMethod]
        public void Test4()
        {
            var list = new SortedList<int, int>();
            var rnd = new Random();
            for (var i = 0; i < 100000; i++)
            {
                list.TryAdd(rnd.Next(int.MinValue, int.MaxValue), 0);
            }
            /*
            var first = heap.Pop();
            for (var i = 1; i < heap.Count(); i++)
            {
                var val = heap.Pop();
                first.Should().BeLessOrEqualTo(val);
            }
            */
        }

        [TestMethod]
        public void Test5()
        {
            var set = new SortedSet<int>();
            var rnd = new Random();
            for (var i = 0; i < 100000; i++)
            {
                set.Add(rnd.Next(int.MinValue, int.MaxValue));
            }
            /*
            var first = heap.Pop();
            for (var i = 1; i < heap.Count(); i++)
            {
                var val = heap.Pop();
                first.Should().BeLessOrEqualTo(val);
            }
            */
        }

        [TestMethod]
        public void Test6()
        {
            var kv = new SortedDictionary<int, int>();
            var rnd = new Random();
            for (var i = 0; i < 100000; i++)
            {
                kv.TryAdd(rnd.Next(int.MinValue, int.MaxValue), 0);
            }
            /*
            var first = heap.Pop();
            for (var i = 1; i < heap.Count(); i++)
            {
                var val = heap.Pop();
                first.Should().BeLessOrEqualTo(val);
            }
            */
        }
    }
}
