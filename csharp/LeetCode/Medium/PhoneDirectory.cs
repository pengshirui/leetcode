namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;

    public class PhoneDirectory
    {
        private readonly Queue<int> Q = new Queue<int>();
        private readonly bool[] Numbers;
        public PhoneDirectory(int maxNumbers)
        {
            Numbers = new bool[maxNumbers];
            for (int i = 0; i < maxNumbers; i++)
            {
                Q.Enqueue(i);
                Numbers[i] = true;
            }
        }

        public int Get()
        {
            if (Q.Any())
            {
                var res = Q.Dequeue();
                Numbers[res] = false;
                return res;
            }
            return -1;
        }

        public bool Check(int number)
        {
            return Numbers[number];
        }

        public void Release(int number)
        {
            if (!Numbers[number])
            {
                Q.Enqueue(number);
                Numbers[number] = true;
            }
        }
    }
}
