namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.GroupStrings;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GroupStringsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.GroupStrings("abc", "bcd", "acef", "xyz", "az", "ba", "a", "z").Should().HaveCount(4);
        }
    }
}
