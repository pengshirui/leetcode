namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NextClosestTimeTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var res1 = _solution.NextClosestTime("01:01");

            res1.Should().Be("01:10");
        }

        [TestMethod]
        public void Test2()
        {
            var res2 = _solution.NextClosestTime("00:00");

            res2.Should().Be("00:00");
        }

        [TestMethod]
        public void Test3()
        {
            var res3 = _solution.NextClosestTime("01:10");

            res3.Should().Be("01:11");
        }

        [TestMethod]
        public void Test4()
        {
            var res4 = _solution.NextClosestTime("23:59");

            res4.Should().Be("22:22");
        }

        [TestMethod]
        public void Test5()
        {
            var res5 = _solution.NextClosestTime("23:52");

            res5.Should().Be("23:53");
        }
    }
}
