using System;
using System.Collections.Generic;

namespace ProductivityTools.TrainingLog.Contract
{
    public class Training
    {
        /// <summary>
        /// Application which is the source of data, it could be Endomondo, Sports-Tracker, or anything we want
        /// </summary>
        public string Application { get; set; }

        /// <summary>
        /// Id of group of trainings, if you have two accounts, like yours and your partner you could add here id
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Id from the TrainingLog Application
        /// </summary>
        public int TrainingId { get; set; }

        /// <summary>
        /// Free text to describe sport, for example you could add some meaningfull information like Olympics 2020
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Additional field to describe sport, for example you could add person with who you had been training
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Type of sport
        /// </summary>
        public TrainingType Sport { get; set; }

        /// <summary>
        /// Every application like Endomondo has source of training and maily it is Manual or GPX
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Start of the training
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// End of the training
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Training duration in Seconds
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Distance in meters
        /// </summary>
        public decimal Distance { get; set; }

        /// <summary>
        /// Calories burned
        /// </summary>
        public decimal Calories { get; set; }

        /// <summary>
        /// Average speed in km/h
        /// </summary>
        public decimal AverageSpeed { get; set; }

        public List<byte[]> Pictures { get; set; }
        public byte[] Gpx { get; set; }

        /// <summary>
        /// Every training can have multiple external Ids, for example, we registered training in Endomondo, than we improtet it to Training Log and than exported to Sports-Tracker, than in external Id we will have two ids: Endomodno and Sports-Tracker
        /// </summary>
        public Dictionary<string, string> ExternalIdList { get; set; }
    }
}
