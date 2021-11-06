namespace LeetCode.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FreqStack
    {
        private readonly Dictionary<int, int> Freq = new Dictionary<int, int>();
        private readonly Dictionary<int, Stack<int>> Recent = new Dictionary<int, Stack<int>>();
        private int MaxFreq = 0;
        public FreqStack()
        {
        }

        public void Push(int val)
        {
            Freq.TryAdd(val, 0);
            Freq[val]++;
            MaxFreq = Math.Max(Freq[val], MaxFreq);
            Recent.TryAdd(Freq[val], new Stack<int>());
            Recent[Freq[val]].Push(val);
        }

        public int Pop()
        {
            var stack = Recent[MaxFreq];
            while (MaxFreq > 0 && !stack.Any())
            {
                MaxFreq--;
                stack = Recent[MaxFreq];
            }
            var ans = stack.Pop();
            Freq[ans]--;
            return ans;
        }
    }
}
