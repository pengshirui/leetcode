namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindOrderTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var p = new int[1][]
            {
                new int[]{ 1,0 },
            };
            var r = new int[] { 0, 1 };
            Solution.FindOrder(2, p).Should().BeEquivalentTo(r);
        }

        [TestMethod]
        public void Test2()
        {
            var p = new int[4][]
            {
                new int[]{ 1,0 },
                new int[]{ 2,0 },
                new int[]{ 3,1 },
                new int[]{ 3,2 },
            };
            var r = new int[] { 0, 2, 3, 1 };
            Solution.FindOrder(4, p).Should().BeEquivalentTo(r);
        }

        [TestMethod]
        public void Test3()
        {
            var p = new int[][]
            {
            };
            Solution.FindOrder(1, p).Should().Equal(0);
        }
    }
}
