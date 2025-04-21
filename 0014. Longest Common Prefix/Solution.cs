using System.Text;

namespace Test._0014._Longest_Common_Prefix
{
    /// <summary>
    /// Finds the longest common prefix among all strings in the input array.
    /// Compares characters positionally across all strings using a vertical scanning method.
    ///
    /// Time Complexity: O(n * m) — where n = number of strings, m = length of the shortest string.
    /// Space Complexity: O(m) — for the result string, in the worst case all characters match.
    /// </summary>
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result = new StringBuilder();
            
            var strsCount = strs.Length;
            var firstStr = strs[0];

            for (int i = 0; i < firstStr.Length; i++)
            {
                var currChar = firstStr[i];
                var isPrefix = true;
                for (int j = 1; j < strsCount; j++)
                {
                    isPrefix = isPrefix && strs[j].Length > i && char.Equals(strs[j][i], currChar);
                }
                if (isPrefix)
                {
                    result.Append(currChar);
                }
                else
                {
                    break;
                }
            }

            return result.ToString();
        }
    }
}
