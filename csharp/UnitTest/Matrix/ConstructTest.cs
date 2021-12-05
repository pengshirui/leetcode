namespace UnitTest.Matrix
{
    using FluentAssertions;
    using LeetCode.Matrix.Construct;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ConstructTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[][] b =
            {
                new int[]{1,1,1,1,0,0,0,0},
                new int[]{1,1,1,1,0,0,0,0},
                new int[]{1,1,1,1,1,1,1,1},
                new int[]{1,1,1,1,1,1,1,1},
                new int[]{1,1,1,1,0,0,0,0},
                new int[]{1,1,1,1,0,0,0,0},
                new int[]{1,1,1,1,0,0,0,0},
                new int[]{1,1,1,1,0,0,0,0},
            };
            var r = Solution.Construct(b);
        }
    }
}