namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GetHintTest
    {
        [TestMethod]
        public void Test1()
        {
            var s = "1807";
            var g = "7810";
            var getHint = new Solution();

            var res = getHint.GetHint(s, g);

            res.Should().Be("1A3B");
        }

        [TestMethod]
        public void Test2()
        {
            var s = "1123";
            var g = "0111";
            var getHint = new Solution();

            var res = getHint.GetHint(s, g);

            res.Should().Be("1A1B");
        }

        [TestMethod]
        public void Test3()
        {
            var s = "1122";
            var g = "1222";
            var getHint = new Solution();

            var res = getHint.GetHint(s, g);

            res.Should().Be("3A0B");
        }
    }
}
