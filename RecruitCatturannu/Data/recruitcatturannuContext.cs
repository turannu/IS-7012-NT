using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using recruitcatturannu.NewFolder;

namespace recruitcatturannu.Data
{
    public class recruitcatturannuContext : DbContext
    {
        public recruitcatturannuContext (DbContextOptions<recruitcatturannuContext> options)
            : base(options)
        {
        }

        public DbSet<recruitcatturannu.NewFolder.Candidate> Candidate { get; set; } = default!;
        public DbSet<recruitcatturannu.NewFolder.Company> Company { get; set; } = default!;
        public DbSet<recruitcatturannu.NewFolder.Industry> Industry { get; set; } = default!;
        public DbSet<recruitcatturannu.NewFolder.JobTitle> JobTitle { get; set; } = default!;
    }
}
