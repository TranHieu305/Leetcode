namespace Test._2352._Equal_Row_and_Column_Pairs
{
    internal class Solution1
    {
        /// <summary>
        /// Counts the number of equal row and column pairs in a square grid.
        /// Converts rows to strings and stores their frequencies in a dictionary,
        /// then builds each column as a string and checks if it matches any row.
        ///
        /// Time Complexity: O(n²) — where n is the size of the grid. 
        ///  - Building and comparing each row and column string takes O(n),
        ///    and there are n rows and n columns: O(n²).
        ///
        /// Space Complexity: O(n²) — for storing all row strings in the dictionary.
        /// </summary>

        public int EqualPairs(int[][] grid)
        {
            var dict = new Dictionary<string, int>();
            foreach (var row in grid)
            {
                var stringRow = string.Join('.', row);
                if (!dict.ContainsKey(stringRow))
                {
                    dict[stringRow] = 0;
                }
                dict[stringRow]++;
            }

            var equalPairs = 0;
            var edge = grid[0].Length;
            for (var columnIndex = 0; columnIndex < edge; columnIndex++)
            {
                var column = new List<int>();
                foreach (var row in grid)
                {
                    column.Add(row[columnIndex]);
                }
                var stringColumn = string.Join('.', column);
                if (dict.ContainsKey(stringColumn.ToString()))
                {
                    equalPairs += dict[stringColumn.ToString()];
                }
            }

            return equalPairs;
        }
    }
}
