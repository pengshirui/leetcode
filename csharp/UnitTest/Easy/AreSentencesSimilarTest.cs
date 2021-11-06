namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AreSentencesSimilarTest
    {
        private readonly Solution solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var sentence1 = new string[] { "i", "great", "acting", "skills" };
            var sentence2 = new string[] { "i", "fine", "drama", "talent" };
            var similarPairs = new string[][]
            {
                new string[] { "great", "g" },
                new string[] { "drama", "acting" },
                new string[] { "skills", "talent" },
                new string[] { "fine", "g" },
            };
            solution.AreSentencesSimilar(sentence1, sentence2, similarPairs).Should().BeTrue();

        }
    }
}
