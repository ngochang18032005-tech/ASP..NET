namespace VANTHINGOCHANG_2123110352.Models
{
    public class AuditLog
    {
        public int Id { get; set; }

        public string Entity { get; set; }
        public int EntityId { get; set; }

        public string Action { get; set; }

        public string OldData { get; set; }
        public string NewData { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
