namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.FullJustify;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FullJustifyTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var words = new string[] { "This", "is", "an", "example", "of", "text", "justification." };
            var r = Solution.FullJustify(words, 16);
            r[0].Should().Be("This    is    an");
            r[1].Should().Be("example  of text");
            r[2].Should().Be("justification.  ");
        }

        [TestMethod]
        public void Test2()
        {
            var words = new string[] { "What", "must", "be", "acknowledgment", "shall", "be" };
            var r = Solution.FullJustify(words, 16);
            r[0].Should().Be("What   must   be");
            r[1].Should().Be("acknowledgment  ");
            r[2].Should().Be("shall be        ");
        }

        [TestMethod]
        public void Test3()
        {
            var words = new string[] { "Listen", "to", "many,", "speak", "to", "a", "few." };
            var r = Solution.FullJustify(words, 6);
            r[0].Should().Be("Listen");
            r[1].Should().Be("to    ");
        }

        [TestMethod]
        public void Test4()
        {
            var words = new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
            var r = Solution.FullJustify(words, 20);
            r[0].Should().Be("Science  is  what we");
            r[4].Should().Be("everything  else  we");
            r[5].Should().Be("do                  ");
        }
    }
}
