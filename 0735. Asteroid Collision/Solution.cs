using System.Diagnostics;

namespace Test._0735._Asteroid_Collision
{
    public class Solution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();

            foreach (var asteroid in asteroids)
            {
                var asteroidDestroyed = false;
                while (stack.Count > 0 && !asteroidDestroyed && asteroid < 0 && stack.Peek() > 0)
                {
                    var lastest = stack.Peek();
                    if (lastest + asteroid == 0) // Both lastest and current are destroyed
                    {
                        stack.Pop();
                        asteroidDestroyed = true;
                    }
                    else if (Math.Abs(asteroid) < Math.Abs(lastest))
                    {
                        asteroidDestroyed = true; // Current is destroyed
                    }
                    else
                    {
                        stack.Pop(); // Lastest is destroyed
                    }
                }

                if (!asteroidDestroyed)
                {
                    stack.Push(asteroid);
                }
            }
            
            return stack.Reverse().ToArray();
        }
    }
}
