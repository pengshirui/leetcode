namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordSquaresTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var r = Solution.WordSquares("area", "lead", "wall", "lady", "ball");
            r[0].Should().Equal("wall", "area", "lead", "lady");
            r[1].Should().Equal("ball", "area", "lead", "lady");
        }
    }
}
