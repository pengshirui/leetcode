namespace LeetCode.Medium.FindSmallestRegion
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public string FindSmallestRegion(IList<IList<string>> regions, string region1, string region2)
        {
            var dict = new Dictionary<string, Region>();
            foreach (var region in regions)
            {
                var parent = region.First();
                if (!dict.ContainsKey(parent))
                {
                    dict[parent] = new Region(parent);
                }
                for (var i = 1; i < region.Count; i++)
                {
                    var r = region[i];
                    if (!dict.ContainsKey(r))
                    {
                        dict[r] = new Region(r);
                    }
                    dict[r].Parent = dict[parent];
                }
            }

            var r1 = dict[region1];
            var r2 = dict[region2];
            var p = r1;
            var q = r2;
            while (p != q)
            {
                p = p.Parent == null ? r2 : p.Parent;
                q = q.Parent == null ? r1 : q.Parent;
            }
            return p.Name;
        }

        class Region
        {
            public string Name { get; set; }
            public Region Parent { get; set; }
            public Region(string name)
            {
                Name = name;
            }
        }
    }
}

