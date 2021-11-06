namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MyAtoiTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "42";

            _solution.MyAtoi(s).Should().Be(42);
        }

        [TestMethod]
        public void Test2()
        {
            var s = "   -42";

            _solution.MyAtoi(s).Should().Be(-42);
        }

        [TestMethod]
        public void Test3()
        {
            var s = "4193 with words";

            _solution.MyAtoi(s).Should().Be(4193);
        }

        [TestMethod]
        public void Test4()
        {
            var s = "words and 987";

            _solution.MyAtoi(s).Should().Be(0);
        }

        [TestMethod]
        public void Test5()
        {
            var s = "-91283472332";

            _solution.MyAtoi(s).Should().Be(-2147483648);
        }

        [TestMethod]
        public void Test6()
        {
            var s = "                    ";

            _solution.MyAtoi(s).Should().Be(0);
        }

        [TestMethod]
        public void Test7()
        {
            var s = int.MaxValue * -1;
            _solution.MyAtoi($"{s}").Should().Be(-2147483647);
        }
    }
}
