namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.FindOriginalArray;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindOriginalArrayTest

    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.FindOriginalArray(1, 3, 4, 2, 6, 8).Should().Equal(1, 3, 4);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.FindOriginalArray(0, 0, 0, 0).Should().Equal(0, 0);
        }
    }
}
