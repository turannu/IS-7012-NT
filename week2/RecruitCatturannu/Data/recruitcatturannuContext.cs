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
    }
}
