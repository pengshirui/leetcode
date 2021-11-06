namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FileSystemTest
    {
        [TestMethod]
        public void Test1()
        {
            var fs = new FileSystem();
            fs.CreatePath("/a", 1);
            fs.Get("/a").Should().Be(1);
        }
    }
}
