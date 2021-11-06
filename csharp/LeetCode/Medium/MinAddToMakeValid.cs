namespace LeetCode.Medium.MinAddToMakeValid
{
    public class Solution
    {
        public int MinAddToMakeValid(string s)
        {
            var result = 0;
            var counter = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
                if (counter < 0)
                {
                    result++;
                    counter = 0;
                }
            }
            return result += counter;
        }
    }
}
