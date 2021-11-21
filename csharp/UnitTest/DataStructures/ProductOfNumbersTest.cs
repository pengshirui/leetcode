namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProductOfNumbersTest
    {
        [TestMethod]
        public void Test1()
        {
            var s = new ProductOfNumbers();
            s.Add(3);
            s.Add(0);
            s.Add(2);
            s.Add(5);
            s.Add(4);
            s.GetProduct(2).Should().Be(20);
            s.GetProduct(3).Should().Be(40);
            s.GetProduct(4).Should().Be(0);
            s.Add(8);
            s.GetProduct(2).Should().Be(32);
        }
    }
}
