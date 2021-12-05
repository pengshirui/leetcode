namespace UnitTest.String
{
    using FluentAssertions;
    using LeetCode.String.ProcessString;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProcessStringTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.ProcessString("11122223445").Should().Be("189");
        }

        [TestMethod]
        public void Test2()
        {
            Solution.ProcessString("1").Should().Be("1");
        }

        [TestMethod]
        public void Test3()
        {
            Solution.ProcessString("9999999").Should().Be("36");
        }
    }
}
