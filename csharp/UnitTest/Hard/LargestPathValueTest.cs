namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.LargestPathValue;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LargestPathValueTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var colors = "abaca";
            var edges = new int[][]
            {
                new int[] {0, 1},
                new int[] {0, 2},
                new int[] {2, 3},
                new int[] {3, 4},
            };

            Solution.LargestPathValue(colors, edges).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var colors = "a";
            var edges = new int[][]
            {
                new int[] {0, 0}
            };

            Solution.LargestPathValue(colors, edges).Should().Be(-1);
        }

        [TestMethod]
        public void Test3()
        {
            var colors = "hhqhuqhqff";
            var edges = new int[][]
            {
                new int[] {0, 1},
                new int[] {0, 2},
                new int[] {2, 3},
                new int[] {3, 4},
                new int[] {3, 5},
                new int[] {5, 6},
                new int[] {2, 7},
                new int[] {6, 7},
                new int[] {7, 8},
                new int[] {3, 8},
                new int[] {5, 8},
                new int[] {8, 9},
                new int[] {3, 9},
                new int[] {6, 9},
            };

            Solution.LargestPathValue(colors, edges).Should().Be(3);
        }

        [TestMethod]
        public void Test4()
        {
            var colors = "nnllnzznn";
            var edges = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 2},
                new int[] {2, 3},
                new int[] {2, 4},
                new int[] {3, 5},
                new int[] {4, 6},
                new int[] {3, 6},
                new int[] {5, 6},
                new int[] {6, 7},
                new int[] {7, 8},
            };

            Solution.LargestPathValue(colors, edges).Should().Be(5);
        }

        [TestMethod]
        public void Test5()
        {
            var colors = "aaa";
            var edges = new int[][]
            {
                new int[] {1, 2},
                new int[] {2, 1},
            };

            Solution.LargestPathValue(colors, edges).Should().Be(-1);
        }

    }
}
