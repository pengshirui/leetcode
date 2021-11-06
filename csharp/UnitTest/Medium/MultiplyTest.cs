using FluentAssertions;
using LeetCode.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Medium
{
    [TestClass]
    public class MultiplyTest
    {
        Solution solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var num1 = "2";
            var num2 = "3";
            var num3 = "123";
            var num4 = "456";
            var num5 = "0";
            var num6 = "100";
            var num7 = "2147483647";
            var num8 = "98";
            var num9 = "9";
            this.solution.Multiply(num1, num2).Should().Be("6");
            this.solution.Multiply(num3, num4).Should().Be("56088");
            this.solution.Multiply(num3, num5).Should().Be("0");
            this.solution.Multiply(num1, num6).Should().Be("200");
            this.solution.Multiply(num7, num7).Should().Be("4611686014132420609");
            this.solution.Multiply(num8, num9).Should().Be("882");

        }
    }
}
