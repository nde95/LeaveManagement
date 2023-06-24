using EmployeeLeave.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeLeave.Web.Models
{
    public class LeaveRequestCreateVM
    {
        [Display(Name = "Start Of Leave")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Of Leave")]
        public DateTime EndDate { get; set; }
        public SelectList LeaveTypes { get; set; }

        [Display(Name = "Leave Requested")]
        public int LeaveTypeId { get; set; }

        [Display(Name = "Comments")]
        public string RequestComments { get; set; }
    }
}
