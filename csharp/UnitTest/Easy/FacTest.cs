namespace UnitTest.Easy
{
    using LeetCode.Easy.Fac;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FacTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.Fac1(10000);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.Fac2(10000);
        }
    }
}
