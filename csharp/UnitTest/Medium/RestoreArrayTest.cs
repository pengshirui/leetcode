namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium.RestoreArray;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RestoreArrayTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var m = new int[][]
            {
                new int[] { 2, 1 },
                new int[] { 3, 4 },
                new int[] { 3, 2 },
            };
            Solution.RestoreArray(m).Should().Equal(1, 2, 3, 4);
        }
    }
}
