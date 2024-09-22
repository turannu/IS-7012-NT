using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace recruitcatturannu.NewFolder
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Enter valid first name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Enter valid last name")]
        public string? LastName { get; set; }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Enter Your Gender")]
        public string? Gender { get; set; }
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }
        [DisplayName("Job Title")]
        public JobTitle? JobTitle { get; set; }
        [DisplayName("Job Title Associated ID")]
        public int JobTitleId { get; set; }


        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
        [Range(0, 100, ErrorMessage = "Enter valid experience")]
        public int Experience { get; set; }
        

        public Industry? Industry { get; set; }
        public int IndustryId { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "Enter valid Email")]
        public string? Email { get; set; }
        [DisplayName("Phone No.")]
        [Required(ErrorMessage = "Phone no. is required")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Enter valid Phone no.")]
        public string? PhoneNumber { get; set; }
        [DisplayName("LinkedIn Url")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "Enter valid Linkedin Link")]
        public string? LinkedInProfile { get; set; }
    }
}
