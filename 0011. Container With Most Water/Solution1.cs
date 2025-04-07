namespace LeetCode._11._Container_With_Most_Water
{
    
    public class Solution
    {
        /// <summary>
        /// Finds the maximum area of water a container can store using the heights of vertical lines.
        /// 
        /// The container is formed by two lines at different indices, and the water area is determined
        /// by the shorter line height multiplied by the distance between the two lines.
        /// 
        /// This uses a two-pointer approach:
        /// - Start with pointers at both ends
        /// - At each step, calculate area and update the max
        /// - Move the pointer at the shorter height inward, because the area is limited by the shorter height,
        ///   and moving the taller side cannot increase the area
        ///
        /// Time Complexity: O(n) - each element is visited at most once
        /// Space Complexity: O(1) - constant extra space
        /// </summary>
        /// <param name="height">Array of line heights</param>
        /// <returns>Maximum water area</returns>
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
                if (height[left] < height[right])
                    left++;
                else
                    right--;       
            }

            return maxArea;
        }
    }
}
