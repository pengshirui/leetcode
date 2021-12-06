namespace UnitTest.String
{
    using FluentAssertions;
    using LeetCode.String.CheckContains;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CheckContainsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            string[] a = { "one", "twoThree", "four" };
            string[] b = { "one", "onetwo" };
            Solution.CheckContains(a, b).Should().BeFalse();
        }

        [TestMethod]
        public void Test2()
        {
            string[] a = { "one", "twoThree", "four" };
            string[] b = { "one", "onetwoThree" };
            Solution.CheckContains(a, b).Should().BeTrue();
        }
    }
}
