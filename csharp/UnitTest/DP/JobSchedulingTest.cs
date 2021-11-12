namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.JobScheduling;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class JobSchedulingTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[] s = { 6, 15, 7, 11, 1, 3, 16, 2 };
            int[] e = { 19, 18, 19, 16, 10, 8, 19, 8 };
            int[] p = { 2, 9, 1, 19, 5, 7, 3, 19 };
            Solution.JobScheduling(s, e, p).Should().Be(41);
        }

        [TestMethod]
        public void Test2()
        {
            int[] s = { 1, 2, 3, 3 };
            int[] e = { 3, 4, 5, 6 };
            int[] p = { 50, 10, 40, 70 };
            Solution.JobScheduling(s, e, p).Should().Be(120);
        }

        [TestMethod]
        public void Test3()
        {
            int[] s = { 1, 1, 1 };
            int[] e = { 2, 3, 4 };
            int[] p = { 5, 6, 4 };
            Solution.JobScheduling(s, e, p).Should().Be(6);
        }
    }
}
