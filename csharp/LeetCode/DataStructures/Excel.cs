namespace LeetCode.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class Excel
    {
        private readonly Cell[,] Table;
        private readonly int M;
        private readonly int N;

        public Excel(int height, char width)
        {
            M = height + 1;
            N = width - 'A' + 1;
            Table = new Cell[M, N];
        }
        public static (int, int) GetPos(string str)
        {
            return (int.Parse(str.Substring(1)), str[0] - 'A');
        }

        public void Set(int row, char column, int val)
        {
            var c = GetCell(row, column - 'A');
            c.SetVal(val);
        }

        public int Get(int row, char column)
        {
            return GetCell(row, column - 'A').GetValue();
        }

        public int Sum(int row, char column, string[] numbers)
        {
            var c = GetCell(row, column - 'A');
            c.SetFormula(Table, numbers);
            return c.GetValue();
        }

        Cell GetCell(int row, int col)
        {
            if (Table[row, col] == null)
            {
                Table[row, col] = new Cell();
            }
            return Table[row, col];
        }
    }

    class Cell
    {
        public int Val;
        public Dictionary<Cell, int> Formula = new Dictionary<Cell, int>();

        public void SetVal(int val)
        {
            Formula.Clear();
            Val = val;
        }

        public void SetFormula(Cell[,] table, string[] strings)
        {
            Formula.Clear();
            foreach (var str in strings)
            {
                if (str.Contains(":"))
                {
                    var nums = str.Split(':');
                    AddCells(table, nums[0], nums[1]);
                }
                else
                {
                    var (row, col) = Excel.GetPos(str);
                    AddCell(table, row, col);
                }
            }
        }

        public int GetValue()
        {
            if (Formula.Any())
            {
                var sum = 0;
                foreach (var (cell, count) in Formula)
                {
                    sum += count * cell.GetValue();
                }
                return sum;
            }
            return Val;
        }

        void AddCells(Cell[,] table, string start, string end)
        {
            var (row1, col1) = Excel.GetPos(start);
            var (row2, col2) = Excel.GetPos(end);
            for (var i = row1; i <= row2; i++)
            {
                for (var j = col1; j <= col2; j++)
                {
                    AddCell(table, i, j);
                }
            }
        }

        void AddCell(Cell[,] table, int i, int j)
        {
            if (table[i, j] == null)
            {
                table[i, j] = new Cell();
            }
            var c = table[i, j];
            Formula.TryAdd(c, 0);
            Formula[c]++;
        }
    }
}
