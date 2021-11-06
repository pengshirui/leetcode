namespace LeetCode.DataStructures
{
    using System.Collections.Generic;

    public class FileSystem
    {
        private readonly File Root = new File();
        public FileSystem()
        {
        }

        public bool CreatePath(string path, int value)
        {
            var paths = path.Split('/');
            var cur = Root;
            for (var i = 0; i < paths.Length - 1; i++)
            {
                var p = paths[i];
                if (string.IsNullOrWhiteSpace(p)) continue;
                if (!cur.Next.ContainsKey(p))
                {
                    return false;
                }
                cur = cur.Next[p];
            }
            var leaf = paths[paths.Length - 1];
            if (cur.Next.ContainsKey(leaf))
            {
                return false;
            }
            cur.Next[leaf] = new File { Name = leaf, Value = value };
            return true;
        }

        public int Get(string path)
        {
            var paths = path.Split('/');
            var cur = Root;
            for (var i = 0; i < paths.Length; i++)
            {
                var p = paths[i];
                if (string.IsNullOrWhiteSpace(p)) continue;
                if (!cur.Next.ContainsKey(p))
                {
                    return -1;
                }
                cur = cur.Next[p];
            }
            return cur.Value;
        }
    }

    public class File
    {
        public string Name { get; set; }
        public Dictionary<string, File> Next = new Dictionary<string, File>();
        public int Value { get; set; }
    }

}
