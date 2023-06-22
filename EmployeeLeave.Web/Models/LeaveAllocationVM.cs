using System.ComponentModel.DataAnnotations;

namespace EmployeeLeave.Web.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
    }
}