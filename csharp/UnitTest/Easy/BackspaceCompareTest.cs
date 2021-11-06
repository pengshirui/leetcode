namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BackspaceCompareTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "xywrrmp";
            var t = "xywrrmu#p";
            Solution.BackspaceCompare(s, t).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var s = "bbbextm";
            var t = "bbb#extm";
            Solution.BackspaceCompare(s, t).Should().BeFalse();
        }

        [TestMethod]
        public void Test3()
        {
            var s = "bxj##tw";
            var t = "bxj###tw";
            Solution.BackspaceCompare(s, t).Should().BeFalse();
        }

        [TestMethod]
        public void Test4()
        {
            var s = "nzp#o#g";
            var t = "b#nzp#o#g";
            Solution.BackspaceCompare(s, t).Should().BeTrue();
        }

        [TestMethod]
        public void Test5()
        {
            var s = "ab##";
            var t = "c#d#";
            Solution.BackspaceCompare(s, t).Should().BeTrue();
        }
    }
}
