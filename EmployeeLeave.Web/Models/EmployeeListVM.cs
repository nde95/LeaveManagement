using System.ComponentModel.DataAnnotations;

namespace EmployeeLeave.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }

        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Hire Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }

    }
}
