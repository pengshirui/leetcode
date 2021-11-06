namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MincostToHireWorkersTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var quality = new int[] { 10, 20, 5 };
            var wage = new int[] { 70, 50, 30 };
            var k = 2;
            Solution.MincostToHireWorkers(quality, wage, k).Should().Be(105);
        }

        [TestMethod]
        public void Test2()
        {
            var quality = new int[] { 3, 1, 10, 10, 1 };
            var wage = new int[] { 4, 8, 2, 2, 7 };
            var k = 3;
            Solution.MincostToHireWorkers(quality, wage, k).Should().Be(30.666666666666664);
        }

        [TestMethod]
        public void Test3()
        {
            var quality = new int[] { 3 };
            var wage = new int[] { 1 };
            var k = 1;
            Solution.MincostToHireWorkers(quality, wage, k).Should().Be(1);
        }

        [TestMethod]
        public void Test4()
        {
            var quality = new int[] { 4, 4, 4, 5 };
            var wage = new int[] { 13, 12, 13, 12 };
            var k = 2;
            Solution.MincostToHireWorkers(quality, wage, k).Should().Be(26);
        }
    }
}
