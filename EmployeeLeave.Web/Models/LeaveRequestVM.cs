﻿using EmployeeLeave.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeLeave.Web.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        [Display(Name = "Time Of Request")]
        public DateTime DateRequested { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
