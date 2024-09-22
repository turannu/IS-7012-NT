

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace recruitcatturannu.NewFolder
{
    public class Industry
    {
        public int Id { get; set; }
        [DisplayName("Industry Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Industry name cannot be longer than 100 characters")]
        public string? IndustryName { get; set; }

        [DisplayName("Sector")]
        [StringLength(50, ErrorMessage = "Sector cannot be longer than 50 characters")]
        public string? Sector { get; set; }

        [DisplayName("Description of Job")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string? Description { get; set; }

        public List<Candidate>? Candidates { get; set; }
        public List<Company>? Companies { get; set; }
    }
}
