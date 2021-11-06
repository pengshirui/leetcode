namespace UnitTest.Hard
{
    using System.Collections.Generic;
    using FluentAssertions;
    using LeetCode.Hard.FirstMissingPositive;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FirstMissingPositiveTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.FirstMissingPositive(1, 2, 0).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.FirstMissingPositive(-1, 0).Should().Be(1);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.FirstMissingPositive(1).Should().Be(2);
        }
    }
}
