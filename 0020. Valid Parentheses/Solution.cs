namespace Test._0020._Valid_Parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var openBrackets = new List<char>() { '[', '{', '(' };
            var dictClostBrackets = new Dictionary<char, char>()
            {
                { ']', '[' },
                { '}', '{' },
                { ')', '(' }
            };

            foreach (char bracket in s)
            {   
                // Push open bracket to stack
                if (openBrackets.Contains(bracket))
                {
                    stack.Push(bracket);
                }
                else 
                {
                    var stackNotEmpty = stack.TryPop(out char top);
                    if (!stackNotEmpty ||  top != dictClostBrackets[bracket]) return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
