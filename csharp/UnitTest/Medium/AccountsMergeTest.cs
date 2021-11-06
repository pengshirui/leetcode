namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AccountsMergeTest
    {
        Solution solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var accounts1 = new string[4][]
            {
                new string[] { "John", "johnsmith@mail.com", "john_newyork@mail.com" },
                new string[] { "John", "johnsmith@mail.com", "john00@mail.com" },
                new string[] { "Mary", "mary@mail.com" },
                new string[] { "John", "johnnybravo@mail.com"}
            };
            //solution.AccountsMerge(accounts1).Should().HaveCount(3);

            var accounts2 = new string[3][]
            {
                new string[] { "Celine","Celine0@m.co","Celine7@m.co","Celine7@m.co" },
                new string[] { "Celine","Celine4@m.co","Celine8@m.co","Celine6@m.co" },
                new string[] { "Celine", "Celine0@m.co", "Celine0@m.co", "Celine4@m.co" },
            };
            solution.AccountsMerge(accounts2).Should().HaveCount(1);
            solution.AccountsMerge(accounts2)[0].Should().HaveCount(6);
        }
    }
}
