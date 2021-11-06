namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.SplitString;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SplitStringTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.SplitString("050043").Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            Solution.SplitString("1234").Should().BeFalse();
        }

        [TestMethod]
        public void Test3()
        {
            Solution.SplitString("9080701").Should().BeFalse();
        }

        [TestMethod]
        public void Test4()
        {
            Solution.SplitString("1000000000999999999").Should().BeTrue();
        }

        [TestMethod]
        public void Test5()
        {
            Solution.SplitString("001").Should().BeFalse();
        }

        [TestMethod]
        public void Test6()
        {
            Solution.SplitString("64424509442147483647").Should().BeFalse();
        }

        [TestMethod]
        public void Test7()
        {
            Solution.SplitString("99999999999999999998").Should().BeTrue();
        }
    }
}
