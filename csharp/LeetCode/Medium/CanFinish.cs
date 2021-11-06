namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var preCounts = new int[numCourses];
            var nextCourses = new Dictionary<int, IList<int>>();

            foreach (var pair in prerequisites)
            {
                var next = pair[0];
                var pre = pair[1];
                preCounts[next]++;
                nextCourses.TryAdd(pre, new List<int>());
                nextCourses[pre].Add(next);
            }

            var q = new Queue<int>();
            for (var i = 0; i < preCounts.Length; i++)
            {
                if (preCounts[i] == 0)
                {
                    q.Enqueue(i);
                }
            }

            var finishedCount = 0;
            while (q.Any())
            {
                var courseId = q.Dequeue();
                finishedCount++;
                if (nextCourses.TryGetValue(courseId, out var courses))
                {
                    foreach (var c in courses)
                    {
                        preCounts[c]--;
                        if (preCounts[c] == 0)
                        {
                            q.Enqueue(c);
                        }
                    }
                }
            }

            return finishedCount == numCourses;
        }
    }

}
