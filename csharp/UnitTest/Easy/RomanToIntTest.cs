namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RomanToIntTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s1 = "III";
            Solution.RomanToInt(s1).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var s2 = "IV";
            Solution.RomanToInt(s2).Should().Be(4);
        }

        [TestMethod]
        public void Test3()
        {
            var s3 = "IX";
            Solution.RomanToInt(s3).Should().Be(9);
        }

        [TestMethod]
        public void Test4()
        {
            var s4 = "LVIII";
            Solution.RomanToInt(s4).Should().Be(58);
        }

        [TestMethod]
        public void Test5()
        {
            var s5 = "MCMXCIV";
            Solution.RomanToInt(s5).Should().Be(1994);
        }

        [TestMethod]
        public void Test6()
        {
            var s6 = "";
            Solution.RomanToInt(s6).Should().Be(0);
        }
    }
}
