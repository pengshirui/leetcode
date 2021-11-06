namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.FindCircleNum;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindCircleNumTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var m = new int[][]
            {
                new int[]{ 1, 1, 1 },
                new int[]{ 1, 1, 1 },
                new int[]{ 1, 1, 1 },
            };
            Solution.FindCircleNum(m).Should().Be(1);
        }
    }
}
