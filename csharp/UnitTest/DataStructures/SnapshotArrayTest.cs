namespace UnitTest.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SnapshotArrayTest
    {
        [TestMethod]
        public void Test1()
        {
            var ssa = new SnapshotArray(3);
            ssa.Set(0, 5);
            var id = ssa.Snap();
            ssa.Set(0, 6);
            ssa.Get(0, id).Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            var ssa = new SnapshotArray(4);
            ssa.Snap();
            ssa.Snap();
            ssa.Get(3, 1);
            ssa.Set(2, 4);
            ssa.Snap();
            ssa.Set(1, 4);
        }


    }
}
