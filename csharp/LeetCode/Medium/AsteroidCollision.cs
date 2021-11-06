namespace LeetCode.Medium.AsteroidCollision
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int[] AsteroidCollision(params int[] asteroids)
        {
            var stack = new Stack<int>();
            foreach (var a in asteroids)
            {
                var broken = false;

                while (stack.Any() && stack.Peek() > 0 && a < 0)
                {
                    if (Math.Abs(stack.Peek()) < Math.Abs(a))
                    {
                        stack.Pop();
                    }
                    else if (a + stack.Peek() == 0)
                    {
                        stack.Pop();
                        broken = true;
                        break;
                    }
                    else
                    {
                        broken = true;
                        break;
                    }
                }

                if (!broken) stack.Push(a);
            }
            return stack.ToArray().Reverse().ToArray();
        }
    }
}
