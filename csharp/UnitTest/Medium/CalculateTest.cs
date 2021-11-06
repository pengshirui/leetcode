namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.Calculate;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CalculateTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.Calculate("1-2").Should().Be(-1);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.Calculate("12+2").Should().Be(14);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.Calculate("10*20*0+1").Should().Be(1);
        }

        [TestMethod]
        public void Test4()
        {
            Solution.Calculate("1+1*2").Should().Be(3);
        }

        [TestMethod]
        public void Test5()
        {
            Solution.Calculate("3/2").Should().Be(1);
        }

        [TestMethod]
        public void Test6()
        {
            Solution.Calculate(" 3+5 / 2 ").Should().Be(5);
        }
    }
}
