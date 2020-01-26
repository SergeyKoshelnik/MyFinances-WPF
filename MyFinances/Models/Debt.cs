namespace MyFinances.Models
{
    public class Debt
    {
        public int Id { get; set; }

        public string DebtName { get; set; }

        public double SummofDebt { get; set; }

        public int UserId { get; set; }

        public string DateEndDate { get; set; }

        public int BorrowerId { get; set; }
    }
}
