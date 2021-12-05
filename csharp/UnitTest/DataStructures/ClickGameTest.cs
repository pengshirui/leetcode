namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ClickGameTest
    {
        [TestMethod]
        public void Test1()
        {
            int[][] b =
            {
                new int[] { 1, 2, 2 },
                new int[] { 1, 2, 2 },
                new int[] { 1, 2, 4 },
                new int[] { 1, 2, 2 },

            };
            var t = new ClickGame(b);
            t.Click(2, 1);
            b[0].Should().Equal(1, 0, 2);
            b[1].Should().Equal(1, 0, 2);
            b[2].Should().Equal(1, 0, 4);
            b[3].Should().Equal(1, 2, 2);
            t.Click(0, 0);
            b[0].Should().Equal(0, 0, 2);
            b[1].Should().Equal(0, 0, 2);
            b[2].Should().Equal(1, 0, 4);
            b[3].Should().Equal(1, 2, 2);
            t.Click(2, 2);
            b[0].Should().Equal(0, 0, 0);
            b[1].Should().Equal(0, 0, 2);
            b[2].Should().Equal(1, 0, 2);
            b[3].Should().Equal(1, 2, 2);
            t.Click(3, 2);
            b[0].Should().Equal(0, 0, 0);
            b[1].Should().Equal(0, 0, 0);
            b[2].Should().Equal(1, 0, 0);
            b[3].Should().Equal(1, 0, 2);
        }

    }
}
