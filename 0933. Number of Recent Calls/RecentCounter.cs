namespace Test._0933._Number_of_Recent_Calls
{
    public class RecentCounter
    {
        private Queue<int> _pingQueue;
        public RecentCounter()
        {
            _pingQueue = new Queue<int>();
        }

        public int Ping(int t)
        {
            _pingQueue.Enqueue(t);
            return countPing(t - 3000, t);
        }

        private int countPing(int timeStart, int timeEnd)
        {
            return _pingQueue.Where(p => p >= timeStart && p <= timeEnd).Count();
        }
    }
}
