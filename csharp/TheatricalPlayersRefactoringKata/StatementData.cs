namespace TheatricalPlayersRefactoringKata
{
    public class StatementData
    {
        public int VolumeCredits { get; }
        public int TotalAmount { get; }

        public StatementData(int volumeCredits, int totalAmount)
        {
            VolumeCredits = volumeCredits;
            TotalAmount = totalAmount;
        }
    }
}