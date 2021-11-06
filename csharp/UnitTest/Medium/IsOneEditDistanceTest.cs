namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsOneEditDistanceTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s1 = "ab";
            var t1 = "acb";
            var s2 = "";
            var t2 = "";
            var s3 = "a";
            var t3 = "";
            var s4 = "";
            var t4 = "A";
            var s5 = "a";
            var t5 = "ac";

            Solution.IsOneEditDistance(s1, t1).Should().BeTrue();
            Solution.IsOneEditDistance(s2, t2).Should().BeFalse();
            Solution.IsOneEditDistance(s3, t3).Should().BeTrue();
            Solution.IsOneEditDistance(s4, t4).Should().BeTrue();
            Solution.IsOneEditDistance(s5, t5).Should().BeTrue();
        }
    }
}
