using System.Text;

namespace LeetCode._0394._Decode_String
{
    class Solution
    {
        public string DecodeString(string s)
        {
            Stack<string> stack = new();
            StringBuilder encoded_string = new();
            StringBuilder time_repeated = new();

            char left_bracket = '[';
            char right_bracket = ']';

            foreach (char c in s)
            {
                // Push all characters not ']' to the stack
                if (!c.Equals(right_bracket))
                {
                    stack.Push(c.ToString());
                    continue;
                }

                // Pop all characters until we find the left bracket
                while (stack.Count > 0 && !stack.Peek().Equals(left_bracket.ToString()))
                {
                    // Build encoded_string
                    encoded_string.Insert(0, stack.Pop());
                }

                // Pop the left bracket
                if (stack.Count > 0)
                {
                    stack.Pop();
                }

                // Pop the digit(s) that represent the number of times to repeat
                while (stack.Count > 0 && int.TryParse(stack.Peek(), out var digit))
                {
                    time_repeated.Insert(0, stack.Pop());
                }

                // Push repeated encode string to stack
                if (int.TryParse(time_repeated.ToString(), out var times))
                {
                    stack.Push(string.Concat(Enumerable.Repeat(encoded_string.ToString(), times)));
                }
                else
                {
                    stack.Push(encoded_string.ToString());
                }

                encoded_string.Clear();
                time_repeated.Clear();
            }

            StringBuilder result = new();
            while (stack.Count > 0)
            {
                // Pop all remain characters from the stack
                result.Insert(0, stack.Pop());
            }

            return result.ToString();
        }
    }
}
