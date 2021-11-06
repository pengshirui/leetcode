namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TotalFruitTest
    {
        readonly Solution _solution = new Solution();
        [TestMethod]
        public void Test1()
        {
            var arr = new int[] { 0, 1, 2, 2 };

            _solution.TotalFruit(arr).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var arr = new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 };
            _solution.TotalFruit(arr).Should().Be(5);
        }

        [TestMethod]
        public void Test3()
        {
            var arr = new int[] { 5, 0, 0, 7, 0, 7, 2, 7 };
            _solution.TotalFruit(arr).Should().Be(5);
        }

        [TestMethod]
        public void Test4()
        {
            var arr = new int[] { 1, 0, 1, 4, 1, 4, 1, 2, 3 };
            _solution.TotalFruit(arr).Should().Be(5);
        }
    }
}
