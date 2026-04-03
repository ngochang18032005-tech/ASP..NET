namespace VANTHINGOCHANG_2123110352.Models
{
    public class Overtime
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateTime Date { get; set; }
        public double Hours { get; set; }

        public double Rate { get; set; } // hệ số lương
    }
}
