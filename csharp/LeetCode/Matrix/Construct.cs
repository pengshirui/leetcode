namespace LeetCode.Matrix.Construct
{
    using System;

    public class Solution
    {
        public Node Construct(int[][] grid)
        {
            var m = grid.Length;
            return Construct(grid, 0, 0, m - 1, m - 1);
        }

        public Node Construct(int[][] grid, int a, int b, int x, int y)
        {
            if (a == x && b == y)
            {
                return new Node(grid[a][b] == 1, true);
            }
            var res = new Node();
            var m = a + x >> 1;
            var n = b + y >> 1;
            var tl = Construct(grid, a, b, m, n);
            var tr = Construct(grid, a, n + 1, m, y);
            var bl = Construct(grid, m + 1, b, x, n);
            var br = Construct(grid, m + 1, n + 1, x, y);

            if (tl.isLeaf && tr.isLeaf && bl.isLeaf && br.isLeaf && tl.val == tr.val && tr.val == bl.val && bl.val == br.val)
            {
                res.isLeaf = true;
                res.val = tl.val;
            }
            else
            {
                res.topLeft = tl;
                res.topRight = tr;
                res.bottomLeft = bl;
                res.bottomRight = br;
            }
            return res;
        }

        public class Node
        {
            public bool val;
            public bool isLeaf;
            public Node topLeft;
            public Node topRight;
            public Node bottomLeft;
            public Node bottomRight;

            public Node()
            {
                val = false;
                isLeaf = false;
                topLeft = null;
                topRight = null;
                bottomLeft = null;
                bottomRight = null;
            }

            public Node(bool _val, bool _isLeaf)
            {
                val = _val;
                isLeaf = _isLeaf;
                topLeft = null;
                topRight = null;
                bottomLeft = null;
                bottomRight = null;
            }

            public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
            {
                val = _val;
                isLeaf = _isLeaf;
                topLeft = _topLeft;
                topRight = _topRight;
                bottomLeft = _bottomLeft;
                bottomRight = _bottomRight;
            }
        }
    }
}
