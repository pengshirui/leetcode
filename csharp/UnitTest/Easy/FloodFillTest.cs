namespace UnitTest.Easy
{
    using System;
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FloodFillTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var image = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 },
            };
            var sr = 1;
            var sc = 1;
            var newColor = 2;

            var r = _solution.FloodFill(image, sr, sc, newColor);
            r[0].Should().Equal(2, 2, 2);
            r[1].Should().Equal(2, 2, 0);
            r[2].Should().Equal(2, 0, 1);
        }
    }
}
