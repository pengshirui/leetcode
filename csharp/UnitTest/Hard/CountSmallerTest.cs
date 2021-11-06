namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.CountSmaller;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CountSmallerTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.CountSmaller(5, 2, 6, 1).Should().Equal(2, 1, 1, 0);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.CountSmaller(1, 1).Should().Equal(0, 0);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.CountSmaller(-1, 0).Should().Equal(0, 0);
        }
    }
}
