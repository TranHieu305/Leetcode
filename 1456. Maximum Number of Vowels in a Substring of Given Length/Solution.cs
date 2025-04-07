using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1456._Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
{
    class Solution
    {
        public int MaxVowels(string s, int k)
        {
            HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u'];
            var current = 0;

            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                    current++;
            }

            var max = current;

            for (int i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                    current++;
                if (vowels.Contains(s[i - k]))
                    current--;
                max = Math.Max(max, current);
            }

            return max;
        }
    }
}
