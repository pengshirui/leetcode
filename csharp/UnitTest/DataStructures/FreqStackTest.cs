namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FreqStackTest
    {
        [TestMethod]
        public void Test1()
        {
            var freqStack = new FreqStack();
            freqStack.Push(5); // The stack is [5]
            freqStack.Push(7); // The stack is [5,7]
            freqStack.Push(5); // The stack is [5,7,5]
            freqStack.Push(7); // The stack is [5,7,5,7]
            freqStack.Push(4); // The stack is [5,7,5,7,4]
            freqStack.Push(5); // The stack is [5,7,5,7,4,5]
            freqStack.Pop().Should().Be(5);   // return 5, as 5 is the most frequent. The stack becomes [5,7,5,7,4].
            freqStack.Pop().Should().Be(7);    // return 7, as 5 and 7 is the most frequent, but 7 is closest to the top. The stack becomes [5,7,5,4].
            freqStack.Pop().Should().Be(5);   // return 5, as 5 is the most frequent. The stack becomes [5,7,4].
            freqStack.Pop().Should().Be(4);    // return 4, as 4, 5 and 7 is the most frequent, but 4 is closest to the top. The stack becomes [5,7].
        }

        [TestMethod]
        public void Test2()
        {
            var freqStack = new FreqStack();
            freqStack.Push(4); // The stack is [4]
            freqStack.Push(0); // The stack is [4,0]
            freqStack.Push(9); // The stack is [4,0,9]
            freqStack.Push(3); // The stack is [4,0,9,3]
            freqStack.Push(4); // The stack is [4,0,9,3,4]
            freqStack.Push(2); // The stack is [4,0,9,3,4,2]
            freqStack.Pop().Should().Be(4);
            freqStack.Push(6);
            freqStack.Pop().Should().Be(6);
            freqStack.Push(1);
            freqStack.Pop().Should().Be(1);
            freqStack.Push(1);
            freqStack.Pop().Should().Be(1);
            freqStack.Push(4);
            freqStack.Pop().Should().Be(4);
            freqStack.Pop().Should().Be(2);
            freqStack.Pop().Should().Be(3);
            freqStack.Pop().Should().Be(9);
            freqStack.Pop().Should().Be(0);
        }
    }
}
