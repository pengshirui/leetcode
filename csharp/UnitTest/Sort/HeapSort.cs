namespace UnitTest.Sort
{
    using FluentAssertions;
    using LeetCode.Sort.HeapSort;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class HeapSortTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[] n = { 3, 2, 1, 5, 6, 4 };
            Solution.HeapSort(n);
            for (var i = 1; i < n.Length; i++)
            {
                (n[i] >= n[i - 1]).Should().BeTrue();
            }
        }

        [TestMethod]
        public void Test2()
        {
            var random = new Random();
            var n = 10;
            var arr = new int[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = random.Next(-10, 10);
            }
            Solution.HeapSort(arr);
            for (var i = 1; i < n; i++)
            {
                (arr[i] >= arr[i - 1]).Should().BeTrue();
            }
        }

        [TestMethod]
        public void Test3()
        {
            var random = new Random();
            var n = (int)1e3;
            var arr = new int[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = random.Next(int.MinValue, int.MaxValue);
            }
            Solution.HeapSort(arr);
            for (var i = 1; i < n; i++)
            {
                (arr[i] >= arr[i - 1]).Should().BeTrue();
            }
        }

        [TestMethod]
        public void Test4()
        {
            var random = new Random();
            var n = (int)1e6;
            var arr = new int[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = random.Next(int.MinValue, int.MaxValue);
            }
            Solution.HeapSort(arr);
            for (var i = 1; i < n; i++)
            {
                (arr[i] >= arr[i - 1]).Should().BeTrue();
            }
        }
    }
}
