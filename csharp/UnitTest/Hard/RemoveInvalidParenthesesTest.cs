namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.RemoveInvalidParentheses;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RemoveInvalidParenthesesTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "()())()";
            Solution.RemoveInvalidParentheses(s).Should().Contain("(())()", "()()()");
        }

        [TestMethod]
        public void Test2()
        {
            var s = "(a)())()";
            Solution.RemoveInvalidParentheses(s).Should().Contain("(a())()", "(a)()()");
        }

        [TestMethod]
        public void Test3()
        {
            var s = ")(";
            Solution.RemoveInvalidParentheses(s).Should().Contain("");
        }

        [TestMethod]
        public void Test4()
        {
            var s = "()())()";
            var r = Solution.RemoveInvalidParentheses(s);
            r.Should().Contain("(())()", "()()()");
            r.Should().HaveCount(2);
        }
    }
}
