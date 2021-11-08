namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.MaxSlidingWindow;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxSlidingWindowTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            var t = 3;
            Solution.MaxSlidingWindow(l, t).Should().Equal(3, 3, 5, 5, 6, 7);
        }

        [TestMethod]
        public void Test2()
        {
            var l = new int[] { 1, -1 };
            var t = 1;
            Solution.MaxSlidingWindow(l, t).Should().Equal(1, -1);
        }
    }
}
