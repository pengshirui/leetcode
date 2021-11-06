namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy.ValidWordAbbreviation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ValidWordAbbreviationTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.ValidWordAbbreviation("internationalization", "i5a11o1").Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            Solution.ValidWordAbbreviation("internationalization", "i12iz4n").Should().BeTrue();
        }

        [TestMethod]
        public void Test3()
        {
            Solution.ValidWordAbbreviation("a", "01").Should().BeFalse();
        }
    }
}
