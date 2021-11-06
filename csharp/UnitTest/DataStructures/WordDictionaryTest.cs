namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordDictionaryTest
    {
        [TestMethod]
        public void Test1()
        {
            var wordDictionary = new WordDictionary();
            wordDictionary.AddWord("a");
            wordDictionary.AddWord("ab");
            wordDictionary.AddWord("bad");
            wordDictionary.AddWord("dad");
            wordDictionary.AddWord("mad");
            wordDictionary.Search("pad").Should().BeFalse();
            wordDictionary.Search("bad").Should().BeTrue();
            wordDictionary.Search(".ad").Should().BeTrue();
            wordDictionary.Search("b..").Should().BeTrue();
            wordDictionary.Search("b").Should().BeFalse();
            wordDictionary.Search("...").Should().BeTrue();
            wordDictionary.Search("a").Should().BeTrue();
        }

    }
}
