namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StrStrTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var haystack = "hello";
            var needle = "ll";
            _solution.StrStr(haystack, needle).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var haystack = "";
            var needle = "";
            _solution.StrStr(haystack, needle).Should().Be(0);
        }

        [TestMethod]
        public void Test3()
        {
            var haystack = "hello";
            var needle = "lzl";
            _solution.StrStr(haystack, needle).Should().Be(-1);
        }

        [TestMethod]
        public void Test4()
        {
            var haystack = "hello";
            var needle = "h";
            _solution.StrStr(haystack, needle).Should().Be(0);
        }

        [TestMethod]
        public void Test5()
        {
            var haystack = "abc";
            var needle = "c";
            _solution.StrStr(haystack, needle).Should().Be(2);
        }
    }
}
