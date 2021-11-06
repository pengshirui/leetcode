namespace LeetCode.DataStructures
{
    using System.Collections.Generic;

    public class LRUCache
    {
        private readonly int Capacity;

        private readonly Dictionary<int, LinkedNode> Dictionary;

        // Most used
        private LinkedNode Head;

        // Least used
        private LinkedNode Tail;

        public LRUCache(int capacity)
        {
            Capacity = capacity;
            Dictionary = new Dictionary<int, LinkedNode>();
            Head = Tail = new LinkedNode();
            Head.Next = Tail;
            Tail.Prev = Head;
        }

        public int Get(int key)
        {
            if (Dictionary.TryGetValue(key, out var node))
            {
                RemoveNode(node);
                MoveToHead(node);
                return node.Val;
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if (Dictionary.TryGetValue(key, out var node))
            {
                RemoveNode(node);
                MoveToHead(node);
                node.Val = value;
            }
            else
            {
                if (Dictionary.Count == Capacity)
                {
                    var last = Tail.Prev;
                    RemoveNode(last);
                    Dictionary.Remove(last.Key);
                }

                var newNode = new LinkedNode { Key = key, Val = value };
                MoveToHead(newNode);
                Dictionary[key] = newNode;
            }
        }

        private void RemoveNode(LinkedNode toRemove)
        {
            // remove current one and relink
            var prev = toRemove.Prev;
            var next = toRemove.Next;
            prev.Next = next;
            next.Prev = prev;
        }

        private void MoveToHead(LinkedNode first)
        {
            // move to head
            var second = Head.Next;
            Head.Next = first;
            first.Prev = Head;
            first.Next = second;
            second.Prev = first;
        }
    }


    class LinkedNode
    {
        public int Key { get; set; }
        public int Val { get; set; }
        public LinkedNode Prev { get; set; }
        public LinkedNode Next { get; set; }
    }

}
