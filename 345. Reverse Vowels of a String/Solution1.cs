using System.Text;

namespace LeetCode._345._Reverse_Vowels_of_a_String
{
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            List<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            if (s.Length == 0) return s;
            
            var sb = new StringBuilder(s);
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (!vowels.Contains(sb[start])) {
                    start++;
                }
                else if (!vowels.Contains(sb[end])) {
                    end--;
                }
                else
                {
                    char temp = sb[start];
                    sb[start] = sb[end];
                    sb[end] = temp;
                    start++;
                    end--;
                }
            }

            return sb.ToString();
        }
    }
}
