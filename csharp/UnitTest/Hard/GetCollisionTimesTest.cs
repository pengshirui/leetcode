namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.GetCollisionTimes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GetCollisionTimesTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var cars = new int[][]
            {
                new int[] { 3, 4 },
                new int[] { 5, 4 },
                new int[] { 6, 3 },
                new int[] { 9, 1 },
            };

            Solution.GetCollisionTimes(cars).Should().Equal(2.00000, 1.00000, 1.50000, -1.00000);
        }

        [TestMethod]
        public void Test2()
        {
            var cars = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 4, 3 },
                new int[] { 7, 2 },
            };

            Solution.GetCollisionTimes(cars).Should().Equal(1.00000, -1.00000, 3.00000, -1.00000);
        }

    }
}
