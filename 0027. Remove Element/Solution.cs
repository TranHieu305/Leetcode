namespace Test._0027._Remove_Element
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int writeIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[writeIndex++] = nums[i];
                }
            }
            return writeIndex;
        }
    }
}
