namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TicTacToeTest
    {
        [TestMethod]
        public void Test1()
        {
            var ttt = new TicTacToe(3);
            ttt.Move(0, 0, 1).Should().Be(0);
            ttt.Move(0, 2, 2).Should().Be(0);
            ttt.Move(2, 2, 1).Should().Be(0);
            ttt.Move(1, 1, 2).Should().Be(0);
            ttt.Move(2, 0, 1).Should().Be(0);
            ttt.Move(1, 0, 2).Should().Be(0);
            ttt.Move(2, 1, 1).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            var ttt = new TicTacToe(3);
            ttt.Move(1, 1, 2).Should().Be(0);
            ttt.Move(0, 2, 2).Should().Be(0);
            ttt.Move(2, 0, 2).Should().Be(2);
        }
    }
}
