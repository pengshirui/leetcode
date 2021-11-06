﻿namespace LeetCode.Medium.FractionToDecimal
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public string fractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0)
            {
                return "0";
            }
            StringBuilder res = new StringBuilder();
            // "+" or "-"
            res.Append(((numerator > 0) ^ (denominator > 0)) ? "-" : "");
            long num = Math.Abs((long)numerator);
            long den = Math.Abs((long)denominator);

            // integral part
            res.Append(num / den);
            num %= den;
            if (num == 0)
            {
                return res.ToString();
            }

            // fractional part
            res.Append(".");
            var map = new Dictionary<long, int>();
            map[num] = res.Length;
            while (num != 0)
            {
                num *= 10;
                res.Append(num / den);
                num %= den;
                if (map.ContainsKey(num))
                {
                    int index = map[num];
                    res.Insert(index, "(");
                    res.Append(")");
                    break;
                }
                else
                {
                    map[num] = res.Length;
                }
            }
            return res.ToString();
        }
    }
}
