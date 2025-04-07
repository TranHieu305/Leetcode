using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1493._Longest_Subarray_of_1_s_After_Deleting_One_Element
{
    class Solution1
    {
        public int LongestSubarray(int[] nums)
        {
            var left = 0;
            var right = 0;
            var countZero = 0;
            var longest = 0;

            while (right < nums.Length)
            {
                if (nums[right] == 0)
                    countZero++;

                // Adjust the window if there are more than one zero
                while (countZero > 1) 
                {
                    if (nums[left] == 0)
                        countZero--; // Decrement countZero if the element at left is 0
                    left++; // Move the left pointer to the right
                }
                if (nums[right] == 1)
                    longest = Math.Max(longest, right - left);

                right++;
            }
            return longest;
        }
    }
}
