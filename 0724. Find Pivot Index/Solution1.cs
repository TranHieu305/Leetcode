namespace LeetCode._0724._Find_Pivot_Index
{
    class Solution1
    {
        /// <summary>
        /// Finds the pivot index where the sum of the numbers to the left 
        /// is equal to the sum of the numbers to the right.
        /// Uses prefix sum and reverse traversal to compare with suffix sum.
        ///
        /// Time Complexity: O(n) — two passes over the array.
        /// Space Complexity: O(n) — uses an extra array for prefix sums.
        /// </summary>
        public int PivotIndex(int[] nums)
        {
            var index = -1;
            var prefixSum = new int[nums.Length];
            prefixSum[0] = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + nums[i];
            }

            var currentSuffixSum = 0;
            
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (prefixSum[i] == currentSuffixSum)
                    index = i;
                currentSuffixSum += nums[i];    
            }

            return index;
        }
    }
}
