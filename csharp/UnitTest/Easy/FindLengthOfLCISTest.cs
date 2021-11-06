namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy.FindLengthOfLCIS;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindLengthOfLCISTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.FindLengthOfLCIS(1, 3, 5, 4, 2, 3, 4, 5).Should().Be(4);
        }
    }
}
