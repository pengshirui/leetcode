namespace LeetCode.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class FileSystem2
    {
        Node root = new Node("");
        public FileSystem2()
        {
        }

        public IList<string> Ls(string path)
        {
            return root.Ls(path);
        }

        public void Mkdir(string path)
        {
            root.Mkdir(path);
        }

        public void AddContentToFile(string filePath, string content)
        {
            root.AddContentToFile(filePath, content);
        }

        public string ReadContentFromFile(string filePath)
        {
            return root.ReadContentFromFile(filePath);
        }

        class Node
        {
            string Name;
            SortedDictionary<string, Node> Next = new SortedDictionary<string, Node>();
            string Content;
            bool IsFolder = true;

            public Node(string n)
            {
                Name = n;
            }

            public Node(string n, bool isFolder)
            {
                Name = n;
                IsFolder = isFolder;
            }

            public void Mkdir(string path)
            {
                if (path == "/")
                {
                    return;
                }
                var parts = path.Split("/");
                var cur = this;
                for (var i = 1; i < parts.Length; i++)
                {
                    cur.Next.TryAdd(parts[i], new Node(parts[i]));
                    cur = cur.Next[parts[i]];
                }
            }

            public IList<string> Ls(string path)
            {
                if (path == "/")
                {
                    return Next.Keys.ToList();
                }
                var parts = path.Split("/");
                var cur = this;
                for (var i = 1; i < parts.Length; i++)
                {
                    cur = cur.Next[parts[i]];
                }
                return cur.IsFolder ? cur.Next.Keys.ToList() : new List<string> { cur.Name };
            }

            public void AddContentToFile(string filePath, string content)
            {
                var parts = filePath.Split("/");
                var cur = this;
                for (var i = 1; i < parts.Length - 1; i++)
                {
                    cur = cur.Next[parts[i]];
                }
                var file = parts[parts.Length - 1];
                cur.Next.TryAdd(file, new Node(file, false));
                cur.Next[file].Content += content;
            }

            public string ReadContentFromFile(string filePath)
            {
                var parts = filePath.Split("/");
                var cur = this;
                for (var i = 1; i < parts.Length - 1; i++)
                {
                    cur = cur.Next[parts[i]];
                }
                var file = parts[parts.Length - 1];
                return cur.Next[file].Content;
            }
        }
    }

    /**
     * Your FileSystem object will be instantiated and called as such:
     * FileSystem obj = new FileSystem();
     * IList<string> param_1 = obj.Ls(path);
     * obj.Mkdir(path);
     * obj.AddContentToFile(filePath,content);
     * string param_4 = obj.ReadContentFromFile(filePath);
     */
}
