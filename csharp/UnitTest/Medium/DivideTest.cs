namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DivideTest
    {
        private readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.Divide(10, 3).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            _solution.Divide(7, -3).Should().Be(-2);
        }

        [TestMethod]
        public void Test3()
        {
            _solution.Divide(1, 1).Should().Be(1);
        }

        [TestMethod]
        public void Test4()
        {
            _solution.Divide(-7, 3).Should().Be(-2);
        }

        [TestMethod]
        public void Test5()
        {
            _solution.Divide(-7, -3).Should().Be(2);
        }

        [TestMethod]
        public void Test6()
        {
            _solution.Divide(1000, -2).Should().Be(-500);
        }

        [TestMethod]
        public void Test7()
        {
            _solution.Divide(1, 2).Should().Be(0);
        }

        [TestMethod]
        public void Test8()
        {
            _solution.Divide(int.MaxValue, 1).Should().Be(int.MaxValue);
        }

        [TestMethod]
        public void Test9()
        {
            _solution.Divide(int.MaxValue, 2).Should().Be(1073741823);
        }

        [TestMethod]
        public void Test10()
        {
            _solution.Divide(int.MinValue, 2).Should().Be(-1073741824);
        }

        [TestMethod]
        public void Test11()
        {
            _solution.Divide(int.MinValue, -3).Should().Be(715827882);
        }
    }
}
