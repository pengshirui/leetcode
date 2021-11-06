namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CheckInclusionTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.CheckInclusion("ab", "eidbaooo").Should().BeTrue();
        }
    }
}
