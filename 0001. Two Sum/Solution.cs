namespace Test._0001._Two_Sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return [map[complement], i];
            }
            else
            {
                map[nums[i]] = i;
            }
        }

        return Array.Empty<int>();
    }
}
