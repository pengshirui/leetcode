namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AddOperatorsTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.AddOperators("123", 6).Should().BeEquivalentTo("1*2*3", "1+2+3");
        }

        [TestMethod]
        public void Test2()
        {
            _solution.AddOperators("123", 123).Should().BeEquivalentTo("123");
        }

        [TestMethod]
        public void Test3()
        {
            _solution.AddOperators("00", 0).Should().BeEquivalentTo("0+0", "0-0", "0*0");
        }

        [TestMethod]
        public void Test4()
        {
            _solution.AddOperators("3456237490", 9191).Should().BeEmpty();
        }
    }
}
