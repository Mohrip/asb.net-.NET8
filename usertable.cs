// Progress.cs
using System;

namespace ProgressTracker.Models
{
    public class Progress
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public int Completed { get; set; }
        public DateTime Date { get; set; }
    }
}
