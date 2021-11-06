namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ExcelTest
    {
        [TestMethod]
        public void Test1()
        {
            var excel = new Excel(3, 'C');
            excel.Set(1, 'A', 2);
            excel.Sum(3, 'C', new string[] { "A1", "A1:B2" });
            excel.Set(2, 'B', 2);
            excel.Get(3, 'C');
        }
    }
}
