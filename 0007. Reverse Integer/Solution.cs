namespace Test._0007._Reverse_Integer
{
    public class Solution
    {
        /// <summary>
        /// Reverses the digits of a 32-bit signed integer.
        /// Returns 0 if the result overflows or is Int32.MinValue.
        /// </summary>
        /// <param name="x">The integer to reverse.</param>
        /// <returns>The reversed integer or 0 if overflow occurs.</returns>
        public int Reverse(int x)
        {
            // Edge case: if x is Int32.MinValue, return 0 because it cannot be reversed within 32-bit range
            if (x == Int32.MinValue) return 0;

            // Check if the number is negative
            var isNegative = x < 0;

            // Reverse the string representation of the absolute value
            var reversed = string.Join(string.Empty, Math.Abs((long)x).ToString().Reverse());

            // Parse the reversed string to an integer
            var isInt = int.TryParse(reversed, out var result);
            
            if (!isInt)
            {
                return 0;
            }

            // If it was negative, return the negative 
            return isNegative ? -result : result;
        }
    }
}
