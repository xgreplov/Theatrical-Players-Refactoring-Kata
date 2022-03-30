namespace TheatricalPlayersRefactoringKata
{
    public class StatementData
    {
        public int VolumeCredits { get; }
        public int TotalAmount { get; }
        public string CustomerName { get; }

        public StatementData(int volumeCredits, int totalAmount, string customerName)
        {
            VolumeCredits = volumeCredits;
            TotalAmount = totalAmount;
            CustomerName = customerName;
        }
    }
}