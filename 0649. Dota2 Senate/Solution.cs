namespace Test._0649._Dota2_Senate
{
    public class Solution
    {
        public string PredictPartyVictory(string senate)
        {
            var turnQueue = new Queue<char>(senate);
            var nextTurnQueue = new Queue<char>();
            var bannedList = new List<char>();
            var banDecision = new Dictionary<char, char> { { 'D', 'R' }, { 'R', 'D' } };

            while (!endGame(turnQueue))
            {
                while (turnQueue.Count > 0)
                {
                    var senator = turnQueue.Dequeue();
                    if (bannedList.Contains(senator)) // Skip banned senator
                    {
                        bannedList.Remove(senator);
                    }
                    else
                    {
                        nextTurnQueue.Enqueue(senator);
                        bannedList.Add(banDecision[senator]); 
                    }
                }

                var emptyQueue = turnQueue;
                turnQueue = nextTurnQueue;
                nextTurnQueue = emptyQueue;
            }

            return turnQueue.Dequeue().Equals('D') ? "Dire" : "Radiant";
        }

        private bool endGame(IEnumerable<char> senators)
        {
            return senators.Distinct().Count() == 1;
        }
    }
}
