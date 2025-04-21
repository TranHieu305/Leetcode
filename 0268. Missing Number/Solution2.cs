namespace Test._0268._Missing_Number
{
    /// <summary>
    /// Finds the missing number using XOR logic:
    /// XORing all indices and all values cancels out duplicates,
    /// leaving only the missing number.
    /// 
    /// XOR is commutative and associative: a ^ a = 0 and a ^ 0 = a
    /// So(0^1^2^...^n) ^ (nums[0]^nums[1]^...^nums[n - 1]) = missing number
    /// 
    /// Time Complexity: O(n) — single pass through the array.
    /// Space Complexity: O(1) — uses constant space.
    /// </summary>
    public class Solution2
    {
        public int MissingNumber(int[] nums)
        {
            var xor = 0;
            for (int index = 0; index < nums.Length; index++) // ^ with index and nums[index]
            {
                xor ^= index ^ nums[index];
            }
            
            xor ^= nums.Length; // xor with last number

            return xor;
        }
    }
}
