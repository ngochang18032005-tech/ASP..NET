namespace VANTHINGOCHANG_2123110352.Models
{
    public class PayrollDetail
    {
        public int Id { get; set; }

        public int SalaryId { get; set; }

        public string Type { get; set; } // Bonus / Penalty / OT
        public double Amount { get; set; }

        public string Note { get; set; }
    }
}
