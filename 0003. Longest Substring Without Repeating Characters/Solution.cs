namespace Test._0003._Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var start = 0;
            var longest = 1;
            var length = s.Length;
            
            if (length == 0)
            {
                return 0;
            }

            for (var end = 1; end <length; end++)
            {
                var indexDuplicate = s.IndexOf(s[end], start, end - start);
                if (indexDuplicate == -1)
                {
                    longest = Math.Max(longest, end - start + 1);
                }
                else
                {
                    start = indexDuplicate + 1;
                }
            }

            return longest;
        }
    }
}
 