namespace UnitTest.ShortestPath
{
    using FluentAssertions;
    using LeetCode.ShortestPath.CurrencyConvert;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CurrencyConvertTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            (int, int, double, double)[] graph =
            {
                (0, 1, 10, 9.8),
                (1, 2, 2, 1.8)
            };

            Solution.CurrencyConvert(3, graph, 0, 1, 10).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            (int, int, double, double)[] graph =
            {
                (0, 1, 10, 9.8),
                (1, 2, 1, 1.8)
            };

            Solution.CurrencyConvert(3, graph, 1, 0, 1).Should().Be(9.8);
        }


        [TestMethod]
        public void Test3()
        {
            (int, int, double, double)[] graph =
            {
                (0, 1, 10, 9.8),
                (1, 2, 2.2, 2)
            };

            Solution.CurrencyConvert(3, graph, 1, 2, 2.2).Should().Be(1);
        }


        [TestMethod]
        public void Test4()
        {
            (int, int, double, double)[] graph =
            {
                (0, 1, 10, 9.8),
                (1, 2, 2.2, 2)
            };

            Solution.CurrencyConvert(3, graph, 2, 1, 1).Should().Be(2);
        }

        [TestMethod]
        public void Test5()
        {
            (int, int, double, double)[] graph =
            {
                (0, 1, 5, 4.8),
                (1, 2, 2, 1.8)
            };

            Solution.CurrencyConvert(3, graph, 0, 2, 10).Should().Be(1);
        }

        [TestMethod]
        public void Test6()
        {
            (int, int, double, double)[] graph =
            {
                (0, 1, 10, 9),
                (1, 2, 2.2, 2)
            };

            Solution.CurrencyConvert(3, graph, 2, 0, 1).Should().Be(18);
        }

        [TestMethod]
        public void Test7()
        {
            (int, int, double, double)[] graph =
            {
                (0, 1, 5, 4.8),
                (1, 2, 2, 1.8),
                (0, 2, 8, 7),
            };

            Solution.CurrencyConvert(3, graph, 0, 2, 10).Should().Be(1.25);
        }

        [TestMethod]
        public void Test8()
        {
            (int, int, double, double)[] graph =
            {
                (0, 1, 5, 4.8),
                (1, 2, 2, 1.8),
                (0, 2, 8, 7),
            };

            Solution.CurrencyConvert(3, graph, 2, 0, 1).Should().Be(8.64);
        }
    }
}
