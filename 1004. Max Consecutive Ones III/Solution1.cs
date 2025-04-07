namespace LeetCode._1004._Max_Consecutive_Ones_III
{
    class Solution1
    {
        /// <summary>
        /// Returns the length of the longest subarray with at most k "0" flipped to "1".
        /// Uses a sliding window to keep track of the window with at most k zeroes.
        ///
        /// Time Complexity: O(n) — each element is visited at most twice.
        /// Space Complexity: O(1) — uses constant extra space.
        /// </summary>
        public int LongestOnes(int[] nums, int k)
        {
            var left = 0;
            var right = 0;
            var countZero = 0;
            var longest = 0;

            while (right < nums.Length)
            {
                if (nums[right] == 0)
                    countZero++;
                // Adjust the window if there are more than k zeroes
                while (countZero > k)
                {
                    if (nums[left] == 0)
                        countZero--; // Decrement countZero if the element at left is 0
                    left++; // Move the left pointer to the right
                }

                longest = Math.Max(longest, right - left + 1); // Update the longest length
                right++;
            }

            return longest;
        }
    }
}
