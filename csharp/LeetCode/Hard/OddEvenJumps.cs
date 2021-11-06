namespace LeetCode.Hard.OddEvenJumps
{
    using System.Collections.Generic;

    public class Solution
    {
        public int OddEvenJumps(int[] arr)
        {
            var sortedList = new SortedList<int, int>();
            var memo = BuildMemo(arr, sortedList);
            var sum = 0;
            for (var i = 0; i < memo.GetLength(0); i++)
            {
                if (memo[i, 1])
                    sum++;
            }
            return sum;
        }

        bool[,] BuildMemo(int[] arr, SortedList<int, int> sortedList)
        {
            var memo = new bool[arr.Length, 2];
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                if (i == arr.Length - 1)
                {
                    memo[i, 0] = true;
                    memo[i, 1] = true;
                }
                else
                {
                    var oddPos = UpperBound(arr[i], sortedList);
                    var evenPos = LowerBound(arr[i], sortedList);
                    memo[i, 1] = oddPos == -1 ? false : memo[oddPos, 0];
                    memo[i, 0] = evenPos == -1 ? false : memo[evenPos, 1];
                }
                sortedList[arr[i]] = i;
            }
            return memo;
        }

        int UpperBound(int key, SortedList<int, int> sortedList)
        {
            // find next number just greater than key;
            if (sortedList.TryGetValue(key, out var val))
            {
                return val;
            }
            else
            {
                var l = 0;
                var r = sortedList.Count - 1;
                while (l < r)
                {
                    var m = l + (r - l) / 2;
                    if (key >= sortedList.Keys[m])
                    {
                        l = m + 1;
                    }
                    else
                    {
                        r = m;
                    }
                }
                return sortedList.Keys[l] > key ? sortedList[sortedList.Keys[l]] : -1;
            }
        }

        int LowerBound(int key, SortedList<int, int> sortedList)
        {
            // find next number just greater than key;
            if (sortedList.TryGetValue(key, out var val))
            {
                return val;
            }
            else
            {
                var l = 0;
                var r = sortedList.Count - 1;
                while (l < r)
                {
                    var m = l + (r - l) / 2;
                    if (key <= sortedList.Keys[m])
                    {
                        r = m;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }

                if (sortedList.Keys[l] > key)
                {
                    if (l - 1 >= 0)
                    {
                        return sortedList[sortedList.Keys[l - 1]];
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return sortedList[sortedList.Keys[l]];
                }
            }
        }


    }
}
