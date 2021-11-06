namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.GetFood;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GetFoodTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var m = new char[][]
            {
                new char[]{'X','X','X','X','X','X'},
                new char[]{'X','*','O','O','O','X'},
                new char[]{'X','O','O','#','O','X'},
                new char[]{'X','X','X','X','X','X'},
            };
            Solution.GetFood(m).Should().Be(3);
        }
    }
}
