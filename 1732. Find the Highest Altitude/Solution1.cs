using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1732._Find_the_Highest_Altitude
{
    class Solution1
    {
        public int LargestAltitude(int[] gain)
        {
            int highestAltitude = 0;
            int currentAltitude = 0;

            foreach (int change in gain)
            {
                currentAltitude += change;
                highestAltitude = Math.Max(currentAltitude, highestAltitude);
            }
            return highestAltitude;
        }
    }
}
