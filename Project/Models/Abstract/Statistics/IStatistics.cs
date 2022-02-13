namespace Diggity.Project.Models.Abstract.Statistics
{
    public interface IStatistics
    {
        public int TotalSecondsPlayed { get; set; }
        public int TotalBlocksMined { get; set; }
        public double TotalCashAccumulated { get; set; }
    }
}