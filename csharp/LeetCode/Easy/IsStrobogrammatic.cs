namespace LeetCode.Easy
{
    public partial class Solution
    {
        public bool IsStrobogrammatic(string num)
        {
            var l = 0;
            var r = num.Length - 1;

            while (l < r)
            {
                if (num[l] == num[r])
                {
                    if (num[l] != '8' && num[l] != '1' && num[l] != '0')
                        return false;
                }
                else
                {
                    var is69 = num[l] == '6' && num[r] == '9';
                    var is96 = num[l] == '9' && num[r] == '6';
                    if (!is69 && !is96)
                    {
                        return false;
                    }
                }

                l++;
                r--;
            }
            if (l == r)
            {
                return num[l] == '8' || num[l] == '1' || num[l] == '0';
            }
            return true;
        }
    }
}
