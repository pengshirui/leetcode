namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReorderLogFilesTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            _solution.ReorderLogFiles(logs).Should().Equal("let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6");
        }

        [TestMethod]
        public void Test2()
        {
            string[] logs = { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
            _solution.ReorderLogFiles(logs).Should().Equal("g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7");
        }

        [TestMethod]
        public void Test3()
        {
            string[] logs = { "dig1 8 1 5 1", "let1 art zero can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            _solution.ReorderLogFiles(logs).Should().Equal("let3 art zero", "let1 art zero can", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6");
        }
    }
}
