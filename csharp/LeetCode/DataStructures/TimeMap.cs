namespace LeetCode.DataStructures
{
    using System.Collections.Generic;

    public class TimeMap
    {
        private readonly Dictionary<string, IList<(int, string)>> Cache = new Dictionary<string, IList<(int, string)>>();
        public TimeMap()
        {

        }

        public void Set(string key, string value, int timestamp)
        {
            Cache.TryAdd(key, new List<(int, string)>());
            Cache[key].Add((timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if (Cache.TryGetValue(key, out var list))
            {
                return GetValue(list, timestamp);
            }
            else
            {
                return string.Empty;
            }
        }

        string GetValue(IList<(int, string)> list, int timestamp)
        {
            var l = 0;
            var r = list.Count - 1;
            if (timestamp < list[0].Item1) return string.Empty;
            if (timestamp >= list[r].Item1) return list[r].Item2;
            while (l + 1 < r)
            {
                var m = (l + r) / 2;
                var middle = list[m].Item1;
                if (middle < timestamp)
                {
                    l = m;
                }
                else if (middle > timestamp)
                {
                    r = m - 1;
                }
                else
                {
                    return list[m].Item2;
                }
            }
            return (list[r].Item1 < timestamp) ? list[r].Item2 : list[l].Item2;
        }
    }
}
