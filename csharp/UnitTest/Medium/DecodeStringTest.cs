namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DecodeStringTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.DecodeString("3[a]2[bc]").Should().Be("aaabcbc");
        }

        [TestMethod]
        public void Test2()
        {
            Solution.DecodeString("3[a2[c]]").Should().Be("accaccacc");
        }

        [TestMethod]
        public void Test3()
        {
            Solution.DecodeString("2[abc]3[cd]ef").Should().Be("abcabccdcdcdef");
        }

        [TestMethod]
        public void Test4()
        {
            Solution.DecodeString("abc3[cd]xyz").Should().Be("abccdcdcdxyz");
        }

        [TestMethod]
        public void Test5()
        {
            Solution.DecodeString("10[cd]").Should().Be("cdcdcdcdcdcdcdcdcdcd");
        }
    }
}
