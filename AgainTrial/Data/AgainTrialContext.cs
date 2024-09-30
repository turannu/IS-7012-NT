using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgainTrial.Model;

namespace AgainTrial.Data
{
    public class AgainTrialContext : DbContext
    {
        public AgainTrialContext (DbContextOptions<AgainTrialContext> options)
            : base(options)
        {
        }

        public DbSet<AgainTrial.Model.Customer> Customer { get; set; } = default!;
        public DbSet<AgainTrial.Model.Item> Item { get; set; } = default!;
        public DbSet<AgainTrial.Model.Order> Order { get; set; } = default!;
        public DbSet<AgainTrial.Model.ShoppingCart> ShoppingCart { get; set; } = default!;
    }
}
