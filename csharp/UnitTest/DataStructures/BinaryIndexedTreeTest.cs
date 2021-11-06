namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BinaryIndexedTreeTest
    {
        [TestMethod]
        public void Test1()
        {
            var t = new BinaryIndexedTree(4);
            t.Update(0, 1);
            t.Update(3, 4);
            t.Query(0, 3).Should().Be(5);
            t.Query(2).Should().Be(1);
            t.Query(1, 3).Should().Be(4);
        }

    }
}
