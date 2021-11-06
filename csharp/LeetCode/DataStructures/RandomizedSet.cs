namespace LeetCode.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RandomizedSet
    {
        private readonly Dictionary<int, int> KV = new Dictionary<int, int>();
        private readonly IList<int> Indices = new List<int>();
        private readonly Random Random = new Random();

        public RandomizedSet()
        {

        }

        public bool Insert(int val)
        {
            if (KV.ContainsKey(val)) return false;
            Indices.Add(val);
            KV.Add(val, Indices.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (KV.TryGetValue(val, out var current))
            {
                var lastItem = Indices.Last();
                Indices[current] = lastItem;
                KV[lastItem] = current;
                Indices.RemoveAt(Indices.Count - 1);
                KV.Remove(val);
                return true;
            }
            return false;
        }

        public int GetRandom()
        {
            return Indices[Random.Next(Indices.Count)];
        }
    }
}
