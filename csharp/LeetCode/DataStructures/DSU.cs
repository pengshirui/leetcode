namespace LeetCode.DataStructures
{
    public class DSU
    {
        int[] Parents;
        int[] Ranks;
        public DSU(int count)
        {
            Parents = new int[count];
            for (var i = 0; i < Parents.Length; i++)
            {
                Parents[i] = i;
            }
            Ranks = new int[count];
        }


        public bool Union(int x, int y)
        {
            var rootX = Find(x);
            var rootY = Find(y);
            var rankX = Ranks[rootX];
            var rankY = Ranks[rootY];

            if (rankX < rankY)
            {
                Parents[rootX] = rootY;
                Ranks[rootY]++;
            }
            else if (rankY < rankX)
            {
                Parents[rootY] = rootX;
                Ranks[rootX]++;
            }
            else
            {
                Parents[rootX] = rootY;
                Ranks[rootY]++;
            }
            return rootX == rootY;
        }

        public int Find(int x)
        {
            while (x != Parents[x])
            {
                x = Parents[x];
            }
            return x;
        }
    }
}
