namespace LeetCode.Easy.CheckRecord
{
    public class Solution
    {
        public bool CheckRecord(string s)
        {
            var absent = 2;
            var late = 3;

            foreach (var c in s)
            {
                if (c == 'A')
                {
                    absent--;
                    if (absent == 0) return false;
                    late = 3;
                }
                else if (c == 'L')
                {
                    late--;
                    if (late == 0) return false;
                }
                else
                {
                    late = 3;
                }
            }
            return true;
        }
    }
}
