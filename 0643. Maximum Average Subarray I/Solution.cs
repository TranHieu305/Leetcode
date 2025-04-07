namespace LeetCode._643._Maximum_Average_Subarray_I
{
    class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var currentSum = nums.Take(k).Sum();
            var maxSum = currentSum;

            for (int i = k; i < nums.Length; i++)
            {
                currentSum += nums[i] - nums[i - k];
                maxSum = Math.Max(maxSum, currentSum);
            }
            return (double)maxSum / k;
        }
    }
}
