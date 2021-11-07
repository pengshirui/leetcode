namespace UnitTest.Bit
{
    using FluentAssertions;
    using LeetCode.Bit.IpToCIDR;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IpToCIDRTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.IpToCIDR("255.0.0.7", 10).Should().Equal("255.0.0.7/32", "255.0.0.8/29", "255.0.0.16/32");
        }
    }
}
