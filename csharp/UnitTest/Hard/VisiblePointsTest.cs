namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.VisiblePoints;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class VisiblePointsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var points = new int[][]
            {
                new int[] {2, 1},
                new int[] {2, 2},
                new int[] {3, 3},
            };
            var angle = 90;
            var location = new int[] { 1, 1 };

            Solution.VisiblePoints(points, angle, location).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var points = new int[][]
            {
                new int[] {1, 0},
                new int[] {2, 1},
            };
            var angle = 13;
            var location = new int[] { 1, 1 };

            Solution.VisiblePoints(points, angle, location).Should().Be(1);
        }

        [TestMethod]
        public void Test3()
        {
            var points = new int[][]
            {
                new int[] {1, 1},
                new int[] {2, 2},
            };
            var angle = 0;
            var location = new int[] { 1, 1 };

            Solution.VisiblePoints(points, angle, location).Should().Be(2);
        }

        [TestMethod]
        public void Test4()
        {
            var points = new int[][]
            {
                new int[] {0, 0},
                new int[] {0, 2},
            };
            var angle = 90;
            var location = new int[] { 1, 1 };

            Solution.VisiblePoints(points, angle, location).Should().Be(2);
        }

        [TestMethod]
        public void Test5()
        {
            var points = new int[][]
            {
                new int[] {0, 0},
                new int[] {0, 2},
                new int[] {3, 0},
            };
            var angle = 180;
            var location = new int[] { 1, 1 };

            Solution.VisiblePoints(points, angle, location).Should().Be(2);
        }
    }
}
