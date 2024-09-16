namespace recruitcatturannu.NewFolder
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DOB { get; set; }
        public bool IsCompleted { get; set; }
        public string? Gender { get; set; }

        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }

        public JobTitle? JobTitle { get; set; }
        public int JobTitleId { get; set; }

        public Company? Company { get; set; }
        public int? CompanyId { get; set; }

        public Industry? Industry { get; set; }
        public int IndustryId { get; set; }
        // Additional properties
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LinkedInProfile { get; set; }
    }
}
