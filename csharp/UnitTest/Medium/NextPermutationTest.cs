namespace UnitTest.Medium
{
    using System;
    using FluentAssertions;
    using LeetCode.Medium.NextPermutation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NextPermutationTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 2, 3 };
            Solution.NextPermutation(nums);

            nums.Should().Equal(1, 3, 2);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 3, 2, 1 };
            Solution.NextPermutation(nums);

            nums.Should().Equal(1, 2, 3);
        }

        [TestMethod]
        public void Test3()
        {
            var nums = Array.Empty<int>();
            Solution.NextPermutation(nums);

            nums.Should().Equal();
        }

        [TestMethod]
        public void Test4()
        {
            var nums = new int[] { 1, 1, 5 };
            Solution.NextPermutation(nums);

            nums.Should().Equal(1, 5, 1);
        }

        [TestMethod]
        public void Test5()
        {
            var nums = new int[] { 1 };
            Solution.NextPermutation(nums);

            nums.Should().Equal(1);
        }
    }
}
