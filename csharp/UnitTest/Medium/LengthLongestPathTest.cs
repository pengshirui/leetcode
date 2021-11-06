namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.LengthLongestPath;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LengthLongestPathTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.LengthLongestPath("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext").Should().Be(20);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.LengthLongestPath("dir\n        file.txt").Should().Be(16);
        }
    }
}
