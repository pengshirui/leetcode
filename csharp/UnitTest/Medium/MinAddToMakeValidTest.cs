namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MinAddToMakeValid;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinAddToMakeValidTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.MinAddToMakeValid("())").Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.MinAddToMakeValid("(()").Should().Be(1);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.MinAddToMakeValid("()").Should().Be(0);
        }
    }
}
