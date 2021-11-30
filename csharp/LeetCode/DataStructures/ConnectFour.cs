namespace LeetCode.DataStructures
{
    public class ConnectFour
    {
        const int m = 7;
        const int n = 6;
        int[, ] b = new int[m, n];
        int cnt = 0;
        int p = 1;
        int[] ds = { 0, -1, 1 };
        int res;
        int[] rows = new int[m];
        public ConnectFour()
        {

        }

        public int Place(int x)
        {
            cnt++;
            var y = rows[x];
            if (x < 0 || x >= m || y >= n) return - 1;
            b[x, y] = p;
            rows[x]++;
            if (Win(x, y)) return p;
            if (cnt == m * n) return -2;
            p = 3 - p;
            return 0;
        }

        bool Win(int x, int y)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (i == j && i == 0) continue;
                    res = 0;
                    DFS(x, y, ds[i], ds[j]);
                    if (res == 4) return true;
                    res = 0;
                }
            }
            return false;
        }

        void DFS(int x, int y, int dx, int dy)
        {
            if (x < 0 || x >= m || y < 0 || y >= n || b[x, y] != p) return;
            res++;
            if (res == 4) return;
            DFS(x + dx, y + dy, dx, dy);
        }
    }
}
