﻿using FluentAssertions;
using LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Easy
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void Test1()
        {
            var arr = new int[] { 2, 7, 11, 15 };
            var t = 9;
            var twoSum = new Solution();

            var res = twoSum.TwoSum(arr, t);

            res.Should().Equal(new int[] { 0, 1 });
        }

        [TestMethod]
        public void Test2()
        {
            var arr = new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            var t = 542;
            var twoSum = new Solution();

            var res = twoSum.TwoSum(arr, t);

            res.Should().Equal(new int[] { 28, 45 });
        }
    }
}
