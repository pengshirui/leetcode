namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.PalindromePairs;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PalindromePairsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var num = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            var r = Solution.PalindromePairs(num);
            r.Should().HaveCount(4);
        }

        [TestMethod]
        public void Test2()
        {
            var num = new string[] { "bat", "tab", "cat" };
            var r = Solution.PalindromePairs(num);
            r.Should().HaveCount(2);
        }

        [TestMethod]
        public void Test3()
        {
            var num = new string[] { "a", "" };
            var r = Solution.PalindromePairs(num);
            r.Should().HaveCount(2);
        }

        [TestMethod]
        public void Test4()
        {
            var num = new string[] { "abb", "a" };
            var r = Solution.PalindromePairs(num);
            r.Should().HaveCount(1);
        }

        [TestMethod]
        public void Test5()
        {
            var num = new string[] { "abcyyyy", "cba" };
            var r = Solution.PalindromePairs(num);
            r.Should().HaveCount(1);
        }
    }
}
