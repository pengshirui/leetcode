namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class NumIslandsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var grid1 = new char[3][]
            {
                new char[3] { '1', '0', '0' },
                new char[3] { '1', '1', '0' },
                new char[3] { '0', '0', '1' }
            };

            var num1 = Solution.NumIslands(grid1);

            num1.Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var grid2 = new char[4][]
            {
                new char[5] { '1', '1', '0', '0', '0' },
                new char[5] { '1', '1', '0', '0', '0' },
                new char[5] { '0', '0', '1', '0', '0' },
                new char[5] { '0', '0', '0', '1', '1' }
            };

            var num2 = Solution.NumIslands(grid2);

            num2.Should().Be(3);
        }

        [TestMethod]
        public void Test3()
        {
            var grid3 = new char[4][]
            {
                new char[5]{ '1','1','1','1','0' },
                new char[5]{ '1','1','0','1','0' },
                new char[5]{ '1','1','0','0','0' },
                new char[5]{ '0','0','0','0','0' },
            };

            var num3 = Solution.NumIslands(grid3);

            num3.Should().Be(1);
        }

        [TestMethod]
        public void Test4()
        {
            var grid4 = new char[1][]
            {
                new char[1]{ '0' },
            };

            var num4 = Solution.NumIslands(grid4);

            num4.Should().Be(0);
        }

        [TestMethod]
        public void Test5()
        {
            var grid5 = new char[3][]
            {
                new char[3] { '1', '1', '1' },
                new char[3] { '0', '1', '0' },
                new char[3] { '1', '1', '1' }
            };

            var num5 = Solution.NumIslands(grid5);

            num5.Should().Be(1);
        }
    }
}
