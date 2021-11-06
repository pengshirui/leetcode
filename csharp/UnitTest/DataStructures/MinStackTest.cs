namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinStackTest
    {
        [TestMethod]
        public void Test1()
        {
            var s = new MinStack();
            s.Push(1);
            s.Push(2);
            s.GetMin().Should().Be(1);
            s.Pop();
            s.GetMin().Should().Be(1);
        }
    }
}
