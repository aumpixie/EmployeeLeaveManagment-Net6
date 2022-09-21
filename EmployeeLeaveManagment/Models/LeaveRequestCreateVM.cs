using EmployeeLeaveManagment.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeLeaveManagment.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name ="Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required]
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }

        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Comments")]
        public string? RequestComments { get; set; }

        public int TotalDays
        {
            get
            {
                if (EndDate.HasValue && StartDate.HasValue)
                {
                    DateTime endingDate = (DateTime)EndDate;
                    DateTime startingDate = (DateTime)StartDate;
                    return (int)(endingDate - startingDate).TotalDays;
                }
                return 0;
            }
        }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date must be Before the End Date", new[] {nameof(StartDate), nameof(EndDate)});
            }

            if(RequestComments?.Length > 250)
            {
                yield return new ValidationResult("Comments are too long", new[] { nameof(RequestComments) });
            }

        }
    }
}
