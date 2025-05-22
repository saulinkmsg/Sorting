using System.Diagnostics;

namespace Sorting.utils
{
    class UtilCountingTime
    {
        Stopwatch stopwatch = new Stopwatch();

        public void Init()
        {
            stopwatch = Stopwatch.StartNew();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        public string TimeElapsed()
        {
            return stopwatch.ToString();
        }
    }
}
