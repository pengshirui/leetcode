namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FileSystem2Test
    {
        [TestMethod]
        public void Test1()
        {
            var fs = new FileSystem2();
            fs.Mkdir("/goowmfn");
            fs.AddContentToFile("/goowmfn/c", "shetopcy");
            fs.Ls("/goowmfn/c").Should().Equal("c");
        }
    }
}
