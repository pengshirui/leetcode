namespace UnitTest.Monotonic
{
    using FluentAssertions;
    using LeetCode.Monotonic.DailyTemperatures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DailyTemperaturesTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.DailyTemperatures(73, 74, 75, 71, 69, 72, 76, 73).Should().Equal(1, 1, 4, 2, 1, 1, 0, 0);
        }
    }
}
