namespace recruitcatturannu.NewFolder
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }

        public bool IsRemote { get; set; }
        public List<Candidate>? Candidates { get; set; }
    }
}
