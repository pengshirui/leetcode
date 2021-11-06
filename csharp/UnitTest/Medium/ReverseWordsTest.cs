namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.ReverseWords;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReverseWordsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.ReverseWords("Bob    Loves  Alice").Should().Be("Alice Loves Bob");
        }
    }
}
