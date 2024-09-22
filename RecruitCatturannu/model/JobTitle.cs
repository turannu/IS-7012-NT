using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace recruitcatturannu.NewFolder
{
    public class JobTitle
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Enter valid title")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Enter valid description")]
        public string? Description { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(0, int.MaxValue, ErrorMessage = "Enter a valid number of Minimum Salary")]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(0, int.MaxValue, ErrorMessage = "Enter a valid number of Maximum Salary")]
        public int MaxSalary { get; set; }
        
        
        public List<Candidate>? Candidates { get; set; }
    }
}
