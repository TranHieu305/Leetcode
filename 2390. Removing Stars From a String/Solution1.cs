namespace Test._2390._Removing_Stars_From_a_String
{
    internal class Solution1
    {
        /// <summary>
        /// Removes characters from the string according to star '*' rules:
        /// each '*' removes the closest character to its left.
        /// Uses a stack (LinkedList) to simulate character removal.
        ///
        /// Time Complexity: O(n) — one pass through the input string.
        /// Space Complexity: O(n) — in the worst case, all characters are stored in the stack.
        /// </summary>
        public string RemoveStars(string s)
        {
            char star = '*';
            var charStack = new LinkedList<char>();
            foreach (char c in s)
            {
                if (c.Equals(star) && charStack.Count > 0)
                {
                    charStack.RemoveLast();
                }
                else
                {
                    charStack.AddLast(c);
                }
            }

            return string.Join(string.Empty, charStack);
        }
    }
}
