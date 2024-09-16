

namespace recruitcatturannu.NewFolder
{
    public class Industry
    {
        public int Id { get; set; }
        public string? IndustryName { get; set; }

        // Additional Properties
        public string? Sector { get; set; }
        public string? Description { get; set; }

        public List<Candidate>? Candidates { get; set; }
        public List<Company>? Companies { get; set; }
    }
}
