namespace LeetCode._1657._Determine_if_Two_Strings_Are_Close
{
    class Solution1
    {
        public bool CloseStrings(string word1, string word2)
        {
            var dict1 = GetCharDic(word1);
            var dict2 = GetCharDic(word2);

            return IsTwoCloseDict(dict1, dict2);
        }

        private Dictionary<char, int> GetCharDic(string word)
        {
            var dict = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 0;
                }
                dict[c]++;
            }
            return dict;
        }

        private bool IsTwoCloseDict(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            // Compare num of unique characters
            if (dict1.Count != dict2.Count)
            {
                return false;
            }

            // Must contain the same unique characters
            var set1 = dict1.Keys.ToHashSet();
            var set2 = dict2.Keys.ToHashSet();
            if (!set1.SetEquals(set2))
            {
                return false;
            }

            // Compare frequency of characters
            var freq1 = dict1.Values.OrderBy(x => x);
            var freq2 = dict2.Values.OrderBy(x => x);

            return freq1.SequenceEqual(freq2);
        }
    }
}
