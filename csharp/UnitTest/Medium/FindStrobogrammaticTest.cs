namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindStrobogrammaticTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.FindStrobogrammatic(1).Should().Equal("0", "1", "8");
        }

        [TestMethod]
        public void Test2()
        {
            _solution.FindStrobogrammatic(2).Should().Equal("11", "69", "88", "96");
        }

        [TestMethod]
        public void Test3()
        {
            _solution.FindStrobogrammatic(4).Should().HaveCount(20);
        }

        [TestMethod]
        public void Test4()
        {
            _solution.FindStrobogrammatic(6).Should().HaveCount(100);
        }

        [TestMethod]
        public void Test5()
        {
            _solution.FindStrobogrammatic(1).Should().Equal("0", "1", "8");
        }

        [TestMethod]
        public void Test6()
        {
            _solution.FindStrobogrammatic(2).Should().Equal("11", "69", "88", "96");
        }

        [TestMethod]
        public void Test7()
        {
            _solution.FindStrobogrammatic(4).Should().HaveCount(20);
        }

        [TestMethod]
        public void Test8()
        {
            _solution.FindStrobogrammatic(6).Should().HaveCount(100);
        }
    }
}
