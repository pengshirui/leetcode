namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.FindSmallestRegion;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindSmallestRegionTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var regions = new string[][]
            {
                new string[] { "Earth", "North America", "South America" },
                new string[] { "North America", "United States", "Canada" },
                new string[] { "United States","New York","Boston" },
                new string[] { "Canada","Ontario","Quebec" },
                new string[] { "South America","Brazil" },
            };
            var region1 = "Quebec";
            var region2 = "New York";
            Solution.FindSmallestRegion(regions, region1, region2).Should().Be("North America");
        }
    }
}
