namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.CheckRecord;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CheckRecordTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.CheckRecord(1).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.CheckRecord(2).Should().Be(8);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.CheckRecord(3).Should().Be(19);
        }

        [TestMethod]
        public void Test4()
        {
            Solution.CheckRecord(4).Should().Be(43);
        }
    }
}
