namespace Test._1207._Unique_Number_of_Occurrences
{
    internal class Solution1
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var occurrences = new Dictionary<int, int>();
            
            foreach (int i in arr)
            {
                if (!occurrences.ContainsKey(i))
                {
                    occurrences[i] = 0;
                }
                occurrences[i]++;
            }

            var uniqueOccurrences = new HashSet<int>();
            foreach (int occurr in occurrences.Values)
            {
                if (uniqueOccurrences.Contains(occurr))
                    return false;
                uniqueOccurrences.Add(occurr);
            }
            return true;
        }
    }
}
