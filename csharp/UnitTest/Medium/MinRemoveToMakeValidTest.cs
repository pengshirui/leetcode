namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MinRemoveToMakeValid;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinRemoveToMakeValidTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.MinRemoveToMakeValid("lee(t(c)o)de)").Should().Be("lee(t(c)o)de");
        }

        [TestMethod]
        public void Test2()
        {
            Solution.MinRemoveToMakeValid("a)b(c)d").Should().Be("ab(c)d");
        }

        [TestMethod]
        public void Test3()
        {
            Solution.MinRemoveToMakeValid("))((").Should().Be("");
        }
    }
}
