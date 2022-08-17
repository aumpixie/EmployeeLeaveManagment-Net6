using System.ComponentModel.DataAnnotations;

namespace EmployeeLeaveManagment.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please Enter a Valid Number")]
        public int DefaultDays { get; set; }
    }
}
