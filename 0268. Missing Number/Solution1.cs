namespace Test._0268._Missing_Number
{
    /// <summary>
    /// Finds the missing number from 0 to n in an array of n distinct numbers.
    /// Uses the arithmetic sum formula to compute the expected total, then subtracts the actual sum.
    ///
    /// Time Complexity: O(n) — summing the array takes linear time.
    /// Space Complexity: O(1) — uses constant extra space.
    /// </summary>
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            var n = nums.Length;
            var fullSum = (n + 1) * n / 2;

            var sum = nums.Sum();

            return fullSum - sum;
        }
    }
}
