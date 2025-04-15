using System.Text;

namespace LeetCode._0394._Decode_String
{
    class Solution
    {
        public string DecodeString(string s)
        {
            Stack<char> stack = new();
            StringBuilder encoded_string = new();
            StringBuilder time_repeated_string = new();
            Stack<string> result = new();
            int time_repeated = 0;

            char left_bracket = '[';
            char right_bracket = ']';

            foreach (var c in s)
            {
                // Push all characters not ']' to the stack
                if (!c.Equals(right_bracket))
                {
                    stack.Push(c);
                    continue;
                }

                // Pop all characters until we find the left bracket
                while (stack.Count > 0 && !stack.Peek().Equals(left_bracket))
                {
                    // Build encoded_string
                    encoded_string.Append(stack.Pop());
                }

                // Pop the left bracket
                if (stack.Count > 0)
                {
                    stack.Pop();
                }

                // Pop the digit(s) that represent the number of times to repeat
                while (stack.Count > 0 && char.IsDigit(stack.Peek()))
                {
                    time_repeated_string.Append(stack.Pop());
                }

                if (int.TryParse(time_repeated_string.ToString(), out time_repeated))
                {
                    result.Push(string.Concat(Enumerable.Repeat(encoded_string.ToString(), time_repeated)));
                }
                encoded_string.Clear();
                time_repeated_string.Clear();
            }

            while (stack.Count > 0)
            {
                // Pop all remain characters from the stack
                result.Push(stack.Pop());
            }

            return string.Join(string.Empty, result.Reverse());
        }
    }
}
