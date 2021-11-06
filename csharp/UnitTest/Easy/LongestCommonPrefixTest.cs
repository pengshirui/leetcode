namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy.LongestCommonPrefix;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestCommonPrefixTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.LongestCommonPrefix("dog", "racecar", "car").Should().Be("");
        }

        [TestMethod]
        public void Test2()
        {
            Solution.LongestCommonPrefix("car").Should().Be("car");
        }
    }
}
