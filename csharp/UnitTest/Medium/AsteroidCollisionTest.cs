namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.AsteroidCollision;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AsteroidCollisionTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.AsteroidCollision(5, 10, -5).Should().Equal(5, 10);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.AsteroidCollision(-1, 1).Should().Equal(-1, 1);
        }
    }
}
