namespace LeetCode.Medium
{
    public partial class Solution
    {
        public string NextClosestTime(string time)
        {
            var parts = time.Split(':');
            var hs = new int[10];
            foreach (var c in time)
            {
                if (c != ':')
                {
                    hs[int.Parse(c.ToString())] = 1;
                }
            }
            var hours = int.Parse(parts[0]);
            var mins = int.Parse(parts[1]);
            var timeInSecond = hours * 60 + mins;

            var diff = 60 * 24;
            var ans = time;
            for (var i = 0; i < 24; i++)
            {
                var first = i / 10;
                var second = i % 10;
                if (hs[first] * hs[second] != 0)
                {
                    for (var j = 0; j < 60; j++)
                    {
                        first = j / 10;
                        second = j % 10;
                        if (hs[first] * hs[second] != 0)
                        {
                            var total = i * 60 + j;
                            var temp = 0;
                            if (total < timeInSecond)
                            {
                                temp = 24 * 60 - timeInSecond + total;
                            }
                            else
                            {
                                temp = total - timeInSecond;
                            }

                            if (temp != 0 && temp < diff)
                            {
                                diff = temp;
                                if (i < 10)
                                {
                                    ans = $"0{i}:";
                                }
                                else
                                {
                                    ans = $"{i}:";
                                }
                                if (j < 10)
                                {
                                    ans += $"0{j}";
                                }
                                else
                                {
                                    ans += $"{j}";
                                }
                            }
                        }
                    }
                }
            }

            return ans;
        }
    }
}
