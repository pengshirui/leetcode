namespace LeetCode.Medium.Crawl
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Solution
    {
        private HtmlParser Parser;
        private string HostName;
        private readonly ConcurrentDictionary<string, bool> Visited = new ConcurrentDictionary<string, bool>();
        public IList<string> Crawl(string startUrl, HtmlParser htmlParser)
        {
            HostName = "http://" + new Uri(startUrl).Host;
            Parser = htmlParser;
            var res = new HashSet<string>();
            DFS(startUrl, res);
            return res.ToList();
        }

        void DFS(string url, HashSet<string> res)
        {
            var urls = Parser.GetUrls(url);
            foreach (var u in urls)
            {
                if (!u.StartsWith(HostName) || res.Contains(u)) continue;
                res.Add(u);
                DFS(u, res);
            }
        }

        public void CCrawl(string url)
        {
            var urls = Parser.GetUrls(url);

            // This will initiate child tasks. Also, it will only return when all the tasks are done.
            Parallel.ForEach(urls, (url) =>
            {
                if (url.StartsWith(HostName) && !Visited.ContainsKey(url))
                {
                    if (Visited.TryAdd(url, true))
                    {
                        CCrawl(url);
                    }
                }
            });
        }

        public interface HtmlParser
        {
            public List<string> GetUrls(string url);
        }

    }
}
