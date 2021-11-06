namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.GetKth;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GetKthTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.GetKth(12, 15, 2).Should().Be(13);
        }
    }
}
