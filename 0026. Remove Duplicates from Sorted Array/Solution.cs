namespace Test._0026._Remove_Duplicates_from_Sorted_Array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;
            var writeIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[writeIndex])
                {
                    nums[++writeIndex] = nums[i];
                }
            }

            return writeIndex + 1;

        }
    }
}
