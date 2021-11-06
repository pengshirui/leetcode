namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.AlienOrder;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AlienOrderTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var w1 = new string[]
            {
                "wrt","wrf","er","ett","rftt"
            };
            Solution.AlienOrder(w1).Should().Be("wertf");
        }

        [TestMethod]
        public void Test2()
        {
            Solution.AlienOrder("ab", "adc").Should().Be("abcd");
        }

        [TestMethod]
        public void Test3()
        {
            Solution.AlienOrder("abc", "ab").Should().Be("");
        }
    }
}
