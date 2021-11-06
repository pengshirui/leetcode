namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public partial class CrackSafeTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var n = 1;
            var k = 2;
            _solution.CrackSafe(n, k).Should().Be("01");
        }

        [TestMethod]
        public void Test2()
        {
            var n = 2;
            var k = 2;
            _solution.CrackSafe(n, k).Should().Be("00110");
        }
    }
}
