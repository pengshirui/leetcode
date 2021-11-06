namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int CompareVersion(string version1, string version2)
        {
            var l1 = version1.Split('.');
            var l2 = version2.Split('.');

            var i = 0;
            while (i < l1.Length || i < l2.Length)
            {
                var v1 = i < l1.Length ? int.Parse(l1[i]) : 0;
                var v2 = i < l2.Length ? int.Parse(l2[i]) : 0;
                if (v1 < v2)
                {
                    return -1;
                }
                else if (v1 > v2)
                {
                    return 1;
                }
                i++;
            }
            return 0;
        }
    }
}
