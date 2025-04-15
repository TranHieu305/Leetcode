namespace Test._2390._Removing_Stars_From_a_String
{
    internal class Solution2
    {
        /// <summary>
        /// Removes characters from the string according to star '*' rules:
        /// each '*' removes the closest character to its left.
        /// Uses a stack-allocated Span for optimal performance and zero heap allocation.
        ///
        /// Time Complexity: O(n) — single pass over the input string.
        /// Space Complexity: O(n) — stack-allocated, avoiding heap usage.
        /// </summary>
        public string RemoveStars(string s)
        {
            Span<char> charStack = stackalloc char[s.Length];
            var len = 0;
            char star = '*';

            foreach (char c in s)
            {
                if (c.Equals(star) && len > 0)
                    len--;
                else
                    charStack[len++] = c;
            }
            
            return charStack[0..len].ToString();
        }
    }
}
