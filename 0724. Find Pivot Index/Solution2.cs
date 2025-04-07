namespace LeetCode._0724._Find_Pivot_Index
{
    class Solution2
    {
        /// <summary>
        /// Finds the pivot index where the sum of the numbers to the left 
        /// equals the sum to the right, using total and running left sum.
        ///
        /// Time Complexity: O(n) — single pass over the array.
        /// Space Complexity: O(1)
        /// </summary>
        public int PivotIndex(int[] nums)
        {
            var totalSum = nums.Sum();
            var leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == totalSum - leftSum - nums[i])
                    return i;
                leftSum += nums[i];
            }

            return -1;
        }
    }
}
