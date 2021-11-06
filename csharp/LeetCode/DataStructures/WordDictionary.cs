namespace LeetCode.DataStructures
{
    public class WordDictionary
    {
        private readonly WordNode Dictionary;

        /** Initialize your data structure here. */
        public WordDictionary()
        {
            Dictionary = new WordNode();
        }

        public void AddWord(string word)
        {
            var current = Dictionary;
            foreach (var c in word)
            {
                var index = c - 'a';
                if (current.Children[index] == null)
                {
                    current.Children[index] = new WordNode();
                }
                current = current.Children[index];
            }
            current.IsWord = true;
        }

        public bool Search(string word)
        {
            return Search(word, Dictionary);
        }

        private bool Search(string word, WordNode Dictionary)
        {
            var current = Dictionary;
            for (var i = 0; i < word.Length; i++)
            {
                var c = word[i];
                if (char.IsLower(c))
                {
                    var index = c - 'a';
                    if (current.Children[index] != null)
                    {
                        current = current.Children[index];
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == '.')
                {
                    for (var j = 0; j < current.Children.Length; j++)
                    {
                        if (current.Children[j] != null)
                        {
                            var newWord = i < word.Length - 1 ? word.Substring(i + 1, word.Length - i - 1) : string.Empty;
                            if (Search(newWord, current.Children[j]))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            return current.IsWord;
        }
    }

    public class WordNode
    {
        public WordNode[] Children { get; set; }

        public bool IsWord { get; set; }

        public WordNode()
        {
            Children = new WordNode[26];
            IsWord = false;
        }
    }

}
