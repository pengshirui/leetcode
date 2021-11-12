namespace LeetCode.Matrix.RotateTheBox
{
    public class Solution
    {
        public char[][] RotateTheBox(char[][] box)
        {
            var m = box.Length;
            var n = box[0].Length;
            var res = new char[n][];
            for (var i = 0; i < n; i++)
            {
                res[i] = new char[m];
            }

            for (var i = 0; i < m; i++)
            {
                var empty = n - 1;
                for (var j = n - 1; j >= 0; j--)
                {
                    if (box[i][j] == '*')
                    {
                        empty = j - 1;
                    }
                    else if (box[i][j] == '#')
                    {
                        box[i][j] = '.';
                        box[i][empty] = '#';
                        empty--;
                    }

                }
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    res[j][m - 1 - i] = box[i][j];
                }
            }

            return res;
        }
    }
}
