namespace UnitTest.Medium
{
    using System;
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumDecodingsTest
    {
        private readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "12";
            _solution.NumDecodings(s).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var s = "226";
            _solution.NumDecodings(s).Should().Be(3);
        }

        [TestMethod]
        public void Test3()
        {
            var s = "0";
            _solution.NumDecodings(s).Should().Be(0);
        }

        [TestMethod]
        public void Test4()
        {
            var s = "10";
            _solution.NumDecodings(s).Should().Be(1);
        }

        [TestMethod]
        public void Test5()
        {
            var s = "210";
            _solution.NumDecodings(s).Should().Be(1);
        }

        [TestMethod]
        public void Test7()
        {
            var s = "1123";
            _solution.NumDecodings(s).Should().Be(5);
        }

        [TestMethod]
        public void Test8()
        {
            var s = "2101";
            _solution.NumDecodings(s).Should().Be(1);
        }
    }
}
