using System.Numerics;

namespace Test._0008._String_to_Integer__atoi_
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            if (s.Length == 0) return 0;

            s = s.Trim();
            BigInteger num = 0;
            var index = 0;
            var isPositive = true;

            if (s[index] == '-' || s[index] == '+')
            {
                isPositive = s[index] == '+';
                index++;
            }

            while (index < s.Length && char.IsDigit(s[index]))
            {
                num = num * 10 + (s[index] - '0');
                index++;
            }

            num = isPositive ? num : -num;

            if (num > int.MaxValue)
            {
                num = int.MaxValue;
            }
            else if (num < int.MinValue)
            {
                num = int.MinValue;
            }

            return (int)num;
        }
    }
}
