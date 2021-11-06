namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.ContainsNearbyAlmostDuplicate;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ContainsNearbyAlmostDuplicateTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var v = new int[] { 1, 2, 2, 3, 4, 5 };
            var k = 3;
            var t = 0;
            Solution.ContainsNearbyAlmostDuplicate(v, k, t).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var v = new int[] { int.MaxValue, int.MaxValue };
            var k = 3;
            var t = 0;
            Solution.ContainsNearbyAlmostDuplicate(v, k, t).Should().BeTrue();
        }
    }
}
