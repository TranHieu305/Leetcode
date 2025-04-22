namespace Test._0217._Contains_Duplicate
{
    public class Solution
    {
        /// <summary>
        /// Checks if the array contains any duplicates by storing elements in a HashSet.
        /// Returns true as soon as a duplicate is found.
        ///
        /// Time Complexity: O(n) — each element is inserted and checked once on average.
        /// Space Complexity: O(n) — stores up to n unique elements in the worst case.
        /// </summary>
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (int i in nums)
            {
                if (set.Contains(i))
                {
                    return true;
                }
                else
                {
                    set.Add(i);
                }
            }

            return false;
        }
    }
}
