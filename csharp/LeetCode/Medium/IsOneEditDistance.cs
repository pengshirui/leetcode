using System;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public bool IsOneEditDistance(string s, string t)
        {

            if (s.Length == t.Length)
            {
                // replace one character
                return this.IsOneEditDistanceWithSameLength(s, t);
            }
            else if (Math.Abs(s.Length - t.Length) == 1)
            {
                return this.IsOneEditDistanceWithDifferentLength(s, t);
            }
            else
            {
                return false;
            }
        }

        private bool IsOneEditDistanceWithSameLength(string s, string t)
        {
            var editTimes = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    editTimes++;
                }
                if (editTimes > 1)
                {
                    return false;
                }
            }
            return editTimes == 1;
        }

        private bool IsOneEditDistanceWithDifferentLength(string s, string t)
        {
            var longStr = t;
            var shortStr = s;
            if (s.Length > t.Length)
            {
                longStr = s;
                shortStr = t;
            }

            var editTimes = 0;
            var i = 0;
            var j = 0;
            while (i < longStr.Length && j < shortStr.Length)
            {
                if (longStr[i] == shortStr[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i++;
                    editTimes++;
                }

                if (editTimes > 1)
                {
                    return false;
                }
            }

            return editTimes == 1 || (longStr.Length - i) == 1;
        }
    }
}
