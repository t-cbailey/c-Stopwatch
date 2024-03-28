using System.Dynamic;

namespace Stopwatch
{

    public class Stopwatch
    {
        private TimeOnly StartTime { get; set; }
        private TimeOnly StopTime { get; set; }
        private bool IsStarted;
        public Stopwatch()
        {
            var startTime = StartTime;
            var stopTime = StopTime;
        }
        public TimeOnly Start
        {
            set
            {
                var now = TimeOnly.FromDateTime(DateTime.Now);
                StartTime = now;
            }
        }

        public TimeOnly Stop
        {
            set
            {
                var now = TimeOnly.FromDateTime(DateTime.Now);
                StopTime = now;

            }
        }

        public void SetStartTime()
        {
            if (IsStarted == true)
            {
                throw new InvalidOperationException();
            }
            else
            {
                var now = TimeOnly.FromDateTime(DateTime.Now);
                StartTime = now;
                IsStarted = true;

            }
        }

        public void SetStopTime()
        {
            var now = TimeOnly.FromDateTime(DateTime.Now);
            StopTime = now;
            IsStarted = false;

        }

        public string TimeDifference
        {
            get
            {
                var timeSpan = StopTime - StartTime;
                var hours = timeSpan.Hours;
                var minutes = timeSpan.Minutes;
                var seconds = timeSpan.Seconds;
                var miliseconds = timeSpan.Milliseconds;
                string result = $"{hours}:{minutes}:{seconds}:{miliseconds}";
                return result;
            }
        }
    }
}

