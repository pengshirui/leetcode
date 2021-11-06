namespace LeetCode.DataStructures
{
    using System;

    public class Master
    {
        public string Word { get; set; }
        private int Chance = 10;
        public int Guess(string word)
        {
            Chance--;
            if (Chance <= 0) throw new Exception();
            var r = 0;
            for (var i = 0; i < 6; i++)
            {
                if (word[i] == Word[i]) r++;
            }
            return r;
        }
    }
}
