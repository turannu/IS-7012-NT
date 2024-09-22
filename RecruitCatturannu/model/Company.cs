
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace recruitcatturannu.NewFolder
{
    public class Company
    {
        public int? CompanyID { get; set; }
        [DisplayName("Company Name")]
        [Required(ErrorMessage = "Company name is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Enter valid Company Name")]
        public string? CompanyName { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(0, int.MaxValue, ErrorMessage = "Enter a valid number of MinimumSalary")]
        public int? MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(0, int.MaxValue, ErrorMessage = "Enter a valid number of Maximum Salary")]
        public int? MaxSalary { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Enter valid Location")]
        public string? Location { get; set; }

        [DisplayName(" Current Position Name")]
        [Required(ErrorMessage = "Position name is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Enter valid Position")]
        public string? Current_PositionName { get; set; }
        [DisplayName("Company Office Location")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Enter valid location")]
        public string? CompanyOfficeLocation { get; set; }


        public Industry? Industry { get; set; }
        [DisplayName("Industry ID")]
        public int? IndustryId { get; set; }

        public List<Candidate>? Candidates { get; set; }
        
        [Range(5000000, int.MaxValue, ErrorMessage = "Enter valid revenue")]
        public int? Revenue { get; set; }





        // Additional properties
        [Url(ErrorMessage = "Enter a valid URL")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Enter valid website")]
        public string? Website { get; set; }
        [DisplayName("Number of Employees")]
        [Range(0, int.MaxValue, ErrorMessage = "Enter a valid number of employees")]
        public int? NumberOfEmployees { get; set; }
    }
}
