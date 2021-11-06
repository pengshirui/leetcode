namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsStrobogrammaticTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.IsStrobogrammatic("111").Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            _solution.IsStrobogrammatic("69").Should().BeTrue();
        }

        [TestMethod]
        public void Test3()
        {
            _solution.IsStrobogrammatic("692").Should().BeFalse(); ;
        }

        [TestMethod]
        public void Test4()
        {
            _solution.IsStrobogrammatic("10").Should().BeFalse(); ;
        }
    }
}
