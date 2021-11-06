namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RotateTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var m = new int[][]
            {
                new int[] {1},
            };

            _solution.Rotate(m);
        }

        [TestMethod]
        public void Test2()
        {
            var m = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };

            _solution.Rotate(m);

            m[0].Should().Equal(7, 4, 1);
            m[1].Should().Equal(8, 5, 2);
            m[2].Should().Equal(9, 6, 3);
        }
    }
}
