namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ExamRoomTest
    {
        [TestMethod]
        public void Test1()
        {
            var r = new ExamRoom(10);
            r.Seat().Should().Be(0);
            r.Seat().Should().Be(9);
            r.Seat().Should().Be(4);
            r.Seat().Should().Be(2);
            r.Leave(4);
            r.Seat().Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            var r = new ExamRoom(10);
            r.Seat().Should().Be(0);
            r.Seat().Should().Be(9);
            r.Leave(0);
            r.Seat().Should().Be(0);
            r.Leave(9);
            r.Seat().Should().Be(9);
            r.Seat().Should().Be(4);
            r.Leave(0);
            r.Seat().Should().Be(0);
        }
    }
}
