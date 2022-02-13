using Diggity.Project.Models.Abstract.Statistics;

namespace Diggity.Project.Models.Concrete.Statistics
{
    public class Statistics : IStatistics
    {
        public Statistics(int TotalSecondsPlayed, int TotalBlocksMined, double TotalCashAccumulated)
        {
            this.TotalSecondsPlayed = TotalSecondsPlayed;
            this.TotalBlocksMined = TotalBlocksMined;
            this.TotalCashAccumulated = TotalCashAccumulated;
        }

        public int TotalSecondsPlayed { get; set; }
        public int TotalBlocksMined { get; set; }
        public double TotalCashAccumulated { get; set; }
    }
}