using System;

namespace LeetCode._2215._Find_the_Difference_of_Two_Arrays
{
    internal class Solution1
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var setNum1 = new HashSet<int>(nums1);
            var setNum2 = new HashSet<int>(nums2);
            var result1 = new List<int>();
            var result2 = new List<int>();

            foreach ( var i in setNum1)
            {
                if (!nums2.Contains(i)) result1.Add(i);
            }
            
            foreach ( var i in setNum2)
            {
                if (!nums1.Contains(i)) result2.Add(i);
            }
            return new List<IList<int>>{result1, result2};
        }
    }
}
