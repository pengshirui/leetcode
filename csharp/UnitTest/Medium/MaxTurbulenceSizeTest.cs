namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxTurbulenceSizeTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.MaxTurbulenceSize(9, 4, 2, 10, 7, 8, 8, 1, 9).Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            _solution.MaxTurbulenceSize(4, 8, 12, 16).Should().Be(2);
        }

        [TestMethod]
        public void Test3()
        {
            _solution.MaxTurbulenceSize().Should().Be(0);
        }

        [TestMethod]
        public void Test4()
        {
            _solution.MaxTurbulenceSize(1).Should().Be(1);
        }

        [TestMethod]
        public void Test5()
        {
            _solution.MaxTurbulenceSize(1, 1).Should().Be(1);
        }
    }
}
