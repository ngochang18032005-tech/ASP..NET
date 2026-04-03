namespace VANTHINGOCHANG_2123110352.Models
{
    public class RolePermission
    {
        public int Id { get; set; }

        public string Role { get; set; } // Admin, HR, Staff
        public string Permission { get; set; } // Create, Read, Update, Delete
    }
}
