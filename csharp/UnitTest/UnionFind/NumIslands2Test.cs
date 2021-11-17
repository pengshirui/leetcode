namespace UnitTest.UnionFind
{
    using FluentAssertions;
    using LeetCode.UnionFind.NumIslands2;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumIslands2Test
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[][] m = 
            {
                new int[] {0, 1},
                new int[] {1, 2},
                new int[] {2, 1},
                new int[] {1, 0},
                new int[] {0, 2},
                new int[] {0, 0},
                new int[] {1, 1},
            };
            Solution.NumIslands2(3, 3, m).Should().Equal(1, 2, 3, 4, 3, 2, 1);
        }

        [TestMethod]
        public void Test2()
        {
            int[][] m =
            {
                new int[] {0, 0},
                new int[] {0, 1},
                new int[] {1, 2},
                new int[] {1, 2},
            };
            Solution.NumIslands2(3, 3, m).Should().Equal(1, 1, 2, 2);
        }

        [TestMethod]
        public void Test3()
        {
            int[][] m =
            {
                new int[] {0, 0},
                new int[] {7, 1},
                new int[] {6, 1},
                new int[] {3, 3},
                new int[] {4, 1},
            };
            Solution.NumIslands2(8, 4, m).Should().Equal(1, 2, 2, 3, 4);
        }
    }
}
