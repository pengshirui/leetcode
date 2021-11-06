namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.CarFleet;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CarFleetTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var t = 10;
            var p = new int[] { 6, 8 };
            var s = new int[] { 3, 2 };
            Solution.CarFleet(t, p, s).Should().Be(2);
        }
    }
}
