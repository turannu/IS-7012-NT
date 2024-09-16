
namespace recruitcatturannu.NewFolder
{
    public class Company
    {
        public int? CompanyID { get; set; }
        public string? CompanyName { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string? Location { get; set; }
        public string? Current_PositionName { get; set; }
        public string? CompanyOfficeLocation { get; set; }


        public Industry? Industry { get; set; }
        public int? IndustryId { get; set; }

        public List<Candidate>? Candidates { get; set; }



        // Additional properties
        public string? Website { get; set; }
        public int? NumberOfEmployees { get; set; }
    }
}
