using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System;
using System.Collections.Generic;

namespace VANTHINGOCHANG_2123110352.Models
{
    public class Employee
    {
        public int Id { get; set; }

        // 🧑 Thông tin cơ bản
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Role { get; set; } // Admin / Manager / Staff
        public string Status { get; set; } = "Active";

        public DateTime DateOfBirth { get; set; }
        public DateTime JoinDate { get; set; }

        public double BaseSalary { get; set; }

        // 🏢 Quan hệ tổ chức
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        public int? PositionId { get; set; }
        public Position Position { get; set; }

        public int? JobLevelId { get; set; }
        public JobLevel JobLevel { get; set; }

        // 🔐 Account
        public UserAccount UserAccount { get; set; }

        // 📅 Ca làm việc
        public ICollection<ShiftAssignment> ShiftAssignments { get; set; }

        // 🕒 Chấm công
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<AttendanceLog> AttendanceLogs { get; set; }

        // 💰 Lương
        public ICollection<Salary> Salaries { get; set; }
        public ICollection<Payroll> Payrolls { get; set; }

        // 💸 Thưởng / phạt
        public ICollection<Bonus> Bonuses { get; set; }
        public ICollection<Penalty> Penalties { get; set; }

        // ⏱️ Tăng ca
        public ICollection<Overtime> Overtimes { get; set; }

        // 🏖️ Nghỉ phép
        public ICollection<LeaveRequest> LeaveRequests { get; set; }

        // 🔔 Thông báo
        public ICollection<Notification> Notifications { get; set; }
    }
}