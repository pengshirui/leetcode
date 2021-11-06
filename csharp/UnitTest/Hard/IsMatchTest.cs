namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsMatchTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "aa";
            var p = "a*";
            _solution.IsMatch(s, p).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var s = "ab";
            var p = ".*";
            _solution.IsMatch(s, p).Should().BeTrue();
        }

        [TestMethod]
        public void Test3()
        {
            var s = "ab";
            var p = "a";
            _solution.IsMatch(s, p).Should().BeFalse();
        }

        [TestMethod]
        public void Test4()
        {
            var s = "mississippi";
            var p = "mis*is*p*.";
            _solution.IsMatch(s, p).Should().BeFalse();
        }

        [TestMethod]
        public void Test5()
        {
            var s = "aab";
            var p = "c*a*b";
            _solution.IsMatch(s, p).Should().BeTrue();
        }

        [TestMethod]
        public void Test6()
        {
            var s = "ab";
            var p = ".*c";
            _solution.IsMatch(s, p).Should().BeFalse();
        }

        [TestMethod]
        public void Test7()
        {
            var s = "aaa";
            var p = "a.a";
            _solution.IsMatch(s, p).Should().BeTrue();
        }

        [TestMethod]
        public void Test8()
        {
            var s = "aaa";
            var p = "a*a";
            _solution.IsMatch(s, p).Should().BeTrue();
        }
    }
}
