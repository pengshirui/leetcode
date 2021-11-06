namespace UnitTest.ShortestPath
{
    using FluentAssertions;
    using LeetCode.ShortestPath.CalcEquation;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CalcEquationTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var equations = new string[][]
            {
                new string[] { "a", "b" },
                new string[] { "b", "c" },
            };
            var values = new double[] { 2.0, 3.0 };
            var queries = new string[][]
            {
                new string[] { "a", "c" },
                new string[] { "b", "a" },
                new string[] { "a", "e" },
                new string[] { "a", "a" },
                new string[] { "x", "x" },
            };

            Solution.CalcEquation(equations, values, queries).Should().Equal(6.00000, 0.50000, -1.00000, 1.00000, -1.00000);
        }

        [TestMethod]
        public void Test2()
        {
            var equations = new string[][]
            {
                new string[] { "a", "b" },
                new string[] { "b", "c" },
                new string[] { "bc", "cd" },

            };
            var values = new double[] { 1.5, 2.5, 5.0 };
            var queries = new string[][]
            {
                new string[] { "a", "c" },
                new string[] { "c", "b" },
                new string[] { "bc", "cd" },
                new string[] { "cd", "bc" },
            };

            Solution.CalcEquation(equations, values, queries).Should().Equal(3.75000, 0.40000, 5.00000, 0.20000);
        }
    }
}
