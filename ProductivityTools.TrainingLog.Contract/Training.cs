using System;

namespace ProductivityTools.TrainingLog.Contract
{
    public class Training
    {
        public string Name { get; set; }
        public string Sport { get; set; }
        public string Source { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimeSpan Duration { get; set; }
        public float Distance { get; set; }
        public float Calories { get; set; }
        public float AverageSpeed { get; set; }
    }
}
