namespace UnitTest.Sort
{
    using FluentAssertions;
    using LeetCode.Sort.QuickSort;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class QuickSortTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[] n = { 3, 2, 1, 5, 6, 4 };
            Solution.QuickSort(n);
            for (var i = 1; i < n.Length; i++)
            {
                (n[i] >= n[i - 1]).Should().BeTrue();
            }
        }

        [TestMethod]
        public void Test2()
        {
            var random = new Random();
            var n = (int)1e3;
            var arr = new int[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = random.Next(int.MinValue, int.MaxValue);
            }
            Solution.QuickSort(arr);
            for (var i = 1; i < n; i++)
            {
                (arr[i] >= arr[i - 1]).Should().BeTrue();
            }
        }

        [TestMethod]
        public void Test3()
        {
            var random = new Random();
            var n = (int)1e5;
            var arr = new int[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = random.Next(int.MinValue, int.MaxValue);
            }
            Solution.QuickSort(arr);
            for (var i = 1; i < n; i++)
            {
                (arr[i] >= arr[i - 1]).Should().BeTrue();
            }
        }
    }
}
