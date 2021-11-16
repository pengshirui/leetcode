namespace UnitTest.Window
{
    using FluentAssertions;
    using LeetCode.Window.MaxSatisfied;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxSatisfiedTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {

            int[] c = { 1, 0, 1, 2, 1, 1, 7, 5 };
            int[] g = { 0, 1, 0, 1, 0, 1, 0, 1 };
            var m = 3;
            Solution.MaxSatisfied(c, g, m).Should().Be(16);
        }

        [TestMethod]
        public void Test2()
        {

            int[] c = { 10, 1, 7 };
            int[] g = { 0, 0, 0 };
            var m = 2;
            Solution.MaxSatisfied(c, g, m).Should().Be(18);
        }

        [TestMethod]
        public void Test3()
        {

            int[] c = { 1 };
            int[] g = { 0 };
            var m = 2;
            Solution.MaxSatisfied(c, g, m).Should().Be(1);
        }

        [TestMethod]
        public void Test4()
        {

            int[] c = { 2, 6, 6 ,9 };
            int[] g = { 0, 0, 1, 1 };
            var m = 1;
            Solution.MaxSatisfied(c, g, m).Should().Be(17);
        }
    }
}
