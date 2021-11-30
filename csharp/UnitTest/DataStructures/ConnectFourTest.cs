namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ConnectFourTest
    {
        [TestMethod]
        public void Test1()
        {
            var cf = new ConnectFour();
            cf.Place(1).Should().Be(0); //r
            cf.Place(1).Should().Be(0); //g
            cf.Place(1).Should().Be(0); //r
            cf.Place(1).Should().Be(0); //g
            cf.Place(1).Should().Be(0); //r
            cf.Place(1).Should().Be(0); //g
            cf.Place(1).Should().Be(-1); //r
            cf.Place(0).Should().Be(0);  //r
            cf.Place(0).Should().Be(0);  //g
            cf.Place(0).Should().Be(0);  //r
            cf.Place(0).Should().Be(0);  //g
            cf.Place(0).Should().Be(0);  //r
            cf.Place(0).Should().Be(0);  //g
            cf.Place(0).Should().Be(-1);  //r
            cf.Place(2).Should().Be(0);  //r
            cf.Place(2).Should().Be(0);  //g
            cf.Place(2).Should().Be(0);  //r
            cf.Place(2).Should().Be(0);  //g
            cf.Place(2).Should().Be(0);  //r
            cf.Place(2).Should().Be(0);  //g
            cf.Place(3).Should().Be(1);  //g
        }

        [TestMethod]
        public void Test2()
        {
            var cf = new ConnectFour();
            cf.Place(2).Should().Be(0); //r
            cf.Place(2).Should().Be(0); //g
            cf.Place(3).Should().Be(0); //r
            cf.Place(1).Should().Be(0); //g
            cf.Place(3).Should().Be(0); //r
            cf.Place(3).Should().Be(0); //g
            cf.Place(4).Should().Be(0); //r
            cf.Place(4).Should().Be(0); //g
            cf.Place(4).Should().Be(0); //r
            cf.Place(4).Should().Be(2); //g
        }
    }
}
