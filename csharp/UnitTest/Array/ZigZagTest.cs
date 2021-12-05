namespace UnitTest.Array
{
    using FluentAssertions;
    using LeetCode.Array.ZigZag;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ZigZagTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.ZigZag(1,2,1,2).Should().Equal(true, true);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.ZigZag(1, 2, 1, 1).Should().Equal(true, false);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.ZigZag(1, 2, 1).Should().Equal(true);
        }
    }
}
