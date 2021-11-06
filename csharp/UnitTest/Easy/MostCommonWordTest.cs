namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MostCommonWordTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var p = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] b = { "hit" };
            _solution.MostCommonWord(p, b).Should().Be("ball");
        }
    }
}
