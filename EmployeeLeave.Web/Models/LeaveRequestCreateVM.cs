using EmployeeLeave.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeLeave.Web.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name = "Start Of Leave")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Of Leave")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public SelectList? LeaveTypes { get; set; }

        [Required]
        [Display(Name = "Leave Requested")]
        public int LeaveTypeId { get; set; }

        [Required]
        [Display(Name = "Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date Must Be Before End Date", new[] { nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}
