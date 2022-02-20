using Diggity.Project.Models.Abstract.Statistics;

namespace Diggity.Project.Models.Concrete.Statistics
{
    public class Statistics : AStatistics
    {
        public Statistics(int TotalSecondsPlayed, int TotalBlocksMined, double TotalCashAccumulated)
        {
            this.TotalSecondsPlayed = TotalSecondsPlayed;
            this.TotalBlocksMined = TotalBlocksMined;
            this.TotalCashAccumulated = TotalCashAccumulated;
        }
    }
}