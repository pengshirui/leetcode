namespace LeetCode.Hard.Trap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int Trap(params int[] height)
        {
            var stack = new Stack<int>();
            var result = 0;
            for (var i = 0; i < height.Length; i++)
            {
                while (stack.Any() && height[stack.Peek()] < height[i])
                {
                    var floorIndex = stack.Pop();
                    if (!stack.Any())
                    {
                        break;
                    }
                    var leftBarIndex = stack.Peek();
                    var leftBar = height[leftBarIndex];
                    var length = i - leftBarIndex - 1;
                    var tall = Math.Min(leftBar, height[i]) - height[floorIndex];
                    result += length * tall;
                }
                stack.Push(i);
            }
            return result;
        }
    }
}
