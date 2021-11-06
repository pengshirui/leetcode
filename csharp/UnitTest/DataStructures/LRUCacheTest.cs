namespace UnitTest.DataStructures
{
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LRUCacheTest
    {
        [TestMethod]
        public void Test1()
        {
            var lru = new LRUCache(2);
            lru.Put(1, 1);
            lru.Put(2, 2);
            lru.Get(1);
            lru.Put(3, 3);

        }
    }
}
