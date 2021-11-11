namespace UnitTest.BFS
{
    using FluentAssertions;
    using LeetCode.BFS.ShortestPathAllKeys;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShortestPathAllKeysTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.ShortestPathAllKeys("@.a.#", "###.#", "b.A.B").Should().Be(8);
        }
    }
}
