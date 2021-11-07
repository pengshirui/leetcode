namespace UnitTest.Sort
{
    using FluentAssertions;
    using LeetCode.Sort.MinMeetingRooms;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinMeetingRoomsTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g = new int[3][]
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 },
            };
            Solution.MinMeetingRooms(g).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var g = new int[2][]
            {
                new int[] { 0,1 },
                new int[] { 1,2 },
            };
            Solution.MinMeetingRooms(g).Should().Be(1);
        }

        [TestMethod]
        public void Test3()
        {
            var g = new int[1][]
            {
                new int[] { 0, 1 },
            };
            Solution.MinMeetingRooms(g).Should().Be(1);
        }
    }
}
