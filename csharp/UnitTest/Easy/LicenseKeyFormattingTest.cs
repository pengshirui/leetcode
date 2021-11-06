namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LicenseKeyFormattingTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.LicenseKeyFormatting("5F3Z-2e-9-w", 4).Should().Be("5F3Z-2E9W");
        }

        [TestMethod]
        public void Test2()
        {
            Solution.LicenseKeyFormatting("--a-a-a-a--", 2).Should().Be("AA-AA");
        }
    }
}
