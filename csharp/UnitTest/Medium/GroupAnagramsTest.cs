namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.GroupAnagrams;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GroupAnagramsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s1 = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            Solution.GroupAnagrams(s1).Should().HaveCount(3);
        }

        [TestMethod]
        public void Test2()
        {
            var s2 = new string[] { "" };
            Solution.GroupAnagrams(s2).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test3()
        {
            var s3 = new string[] { "a" };
            Solution.GroupAnagrams(s3).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test4()
        {
            var s4 = new string[] { };
            Solution.GroupAnagrams(s4).Should().HaveCount(0);
        }
    }
}
