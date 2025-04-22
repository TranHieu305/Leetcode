namespace Test._0448._Find_All_Numbers_Disappeared_in_an_Array
{
    public class Solution
    {
        /// <summary>
        /// Finds all numbers in the range [1, n] that are missing from the array.
        /// Marks the presence of a number by negating the value at its corresponding index.
        /// Positive values at the end indicate missing numbers.
        ///
        /// Time Complexity: O(n) — two linear passes over the array.
        /// Space Complexity: O(1) — modifies input array in-place and uses only output list.
        /// </summary>

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i  = 0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] = -nums[index]; // Convert value of index where value exist to negative. Eg: nums[0] = 2 => nums[1] to negative
                }
            }

            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(i + 1);
                }
            }

            return result;
        }
    }
}
