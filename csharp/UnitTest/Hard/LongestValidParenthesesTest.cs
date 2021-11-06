namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestValidParenthesesTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.LongestValidParentheses("()(())").Should().Be(6);
            _solution.LongestValidParentheses2("()(())").Should().Be(6);
        }

        [TestMethod]
        public void Test2()
        {
            _solution.LongestValidParentheses("(()())").Should().Be(6);
            _solution.LongestValidParentheses2("(()())").Should().Be(6);
        }

        [TestMethod]
        public void Test3()
        {
            _solution.LongestValidParentheses("(()").Should().Be(2);
            _solution.LongestValidParentheses2("(()").Should().Be(2);
        }
    }
}
