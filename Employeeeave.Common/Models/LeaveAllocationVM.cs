﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeLeave.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        [Required]
        [Range(1, 50, ErrorMessage = "Invalid Number Of Days")]
        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}