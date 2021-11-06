namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var kv = new Course[numCourses];
            for (var i = 0; i < numCourses; i++)
            {
                kv[i] = new Course
                {
                    Id = i
                };
            }
            foreach (var relation in prerequisites)
            {
                var prereq = kv[relation[1]];
                var next = kv[relation[0]];

                prereq.NextCourses.Add(next);
                next.Prereq++;
            }

            var q = new Queue<int>();
            foreach (var c in kv)
            {
                if (c.Prereq == 0)
                {
                    q.Enqueue(c.Id);
                }
            }

            var ans = new List<int>();
            while (q.Any())
            {
                var course = q.Dequeue();
                ans.Add(course);
                foreach (var nextCourse in kv[course].NextCourses)
                {
                    nextCourse.Prereq--;
                    if (nextCourse.Prereq == 0)
                    {
                        q.Enqueue(nextCourse.Id);
                    }
                }
            }
            return ans.Count == numCourses ? ans.ToArray() : new int[0];
        }

        class Course
        {
            public int Prereq { get; set; }
            public int Id { get; set; }
            public IList<Course> NextCourses = new List<Course>();
        }
    }

}
