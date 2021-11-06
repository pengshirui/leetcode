namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.GridIllumination;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GridIlluminationTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var n = 5;
            var lamps = new int[][]
            {
                new int[] {0,0},
                new int[] {4,4},
            };
            var queries = new int[][]
            {
                new int[]{1,1},
                new int[]{1,0},
            };

            Solution.GridIllumination(n, lamps, queries).Should().Equal(1, 0);
        }

        [TestMethod]
        public void Test2()
        {
            var n = 5;
            var lamps = new int[][]
            {
                new int[] {0,0},
                new int[] {4,4},
            };
            var queries = new int[][]
            {
                new int[]{1,1},
                new int[]{1,1},
            };

            Solution.GridIllumination(n, lamps, queries).Should().Equal(1, 1);
        }

        [TestMethod]
        public void Test3()
        {
            var n = 5;
            var lamps = new int[][]
            {
                new int[] {0,0},
                new int[] {0,4},
            };
            var queries = new int[][]
            {
                new int[]{0,4},
                new int[]{0,1},
                new int[]{1,4},
            };

            Solution.GridIllumination(n, lamps, queries).Should().Equal(1, 1, 0);
        }

        [TestMethod]
        public void Test4()
        {
            var n = 6;
            var lamps = new int[][]
            {
                new int[] {2,5},
                new int[] {4,2},
                new int[] {0,3},
                new int[] {0,5},
                new int[] {1,4},
                new int[] {4,2},
                new int[] {3,3},
                new int[] {1,0},
            };
            var queries = new int[][]
            {
                new int[]{4,3},
                new int[]{3,1},
                new int[]{5,3},
                new int[]{0,5},
                new int[]{4,4},
                new int[]{3,3},
            };

            Solution.GridIllumination(n, lamps, queries).Should().Equal(1, 0, 1, 1, 0, 1);
        }

        [TestMethod]
        public void Test5()
        {
            var n = 6;
            var lamps = new int[][]
            {
                new int[] {1,1},
            };
            var queries = new int[][]
            {
                new int[]{2,0},
                new int[]{1,0},
            };

            Solution.GridIllumination(n, lamps, queries).Should().Equal(1, 0);
        }
    }
}
