namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.FindMaxValueOfEquation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindMaxValueOfEquationTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var points = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 0 },
                new int[] { 5, 10 },
                new int[] { 6, -10 },
            };
            var k = 1;
            Solution.FindMaxValueOfEquation(points, k).Should().Be(4);
        }

        [TestMethod]
        public void Test2()
        {
            var points = new int[][]
            {
                new int[] { -19, 9 },
                new int[] { -15, -19 },
                new int[] { -5, -8 },
            };
            var k = 10;
            Solution.FindMaxValueOfEquation(points, k).Should().Be(-6);
        }
    }
}
