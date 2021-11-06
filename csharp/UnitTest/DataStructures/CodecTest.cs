namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CodecTest
    {
        [TestMethod]
        public void Test1()
        {
            var codec = new Codec();
            var node = TreeNode.GetTreeNode(1, 2, 3, null, null, 4, 5);
            codec.deserialize(codec.serialize(node)).Should().BeEquivalentTo(node);
        }
    }
}
