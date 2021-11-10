namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MedianFinderTest
    {
        [TestMethod]
        public void Test1()
        {
            var mf = new MedianFinder();
            mf.AddNum(1);
            mf.AddNum(2);
            mf.FindMedian().Should().Be(1.5);
        }

        [TestMethod]
        public void Test2()
        {
            var mf = new MedianFinder();
            mf.AddNum(1);
            mf.AddNum(2);
            mf.AddNum(3);
            mf.AddNum(4);
            mf.AddNum(5);
            mf.FindMedian().Should().Be(3);
        }

        [TestMethod]
        public void Test3()
        {
            var mf = new MedianFinder();
            mf.AddNum(1);
            mf.FindMedian().Should().Be(1);
            mf.AddNum(2);
            mf.FindMedian().Should().Be(1.5);
            mf.AddNum(3);
            mf.FindMedian().Should().Be(2);
            mf.AddNum(4);
            mf.FindMedian().Should().Be(2.5);
            mf.AddNum(5);
            mf.FindMedian().Should().Be(3);
            mf.AddNum(6);
            mf.FindMedian().Should().Be(3.5);
            mf.AddNum(7);
            mf.FindMedian().Should().Be(4);
            mf.AddNum(8);
            mf.FindMedian().Should().Be(4.5);
            mf.AddNum(9);
            mf.FindMedian().Should().Be(5);
            mf.AddNum(10);
            mf.FindMedian().Should().Be(5.5);
        }
    }
}
