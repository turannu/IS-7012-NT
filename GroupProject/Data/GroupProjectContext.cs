using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroupProject.Model;

namespace GroupProject.Data
{
    public class GroupProjectContext : DbContext
    {
        public GroupProjectContext (DbContextOptions<GroupProjectContext> options)
            : base(options)
        {
        }

        public DbSet<GroupProject.Model.Customer> Customer { get; set; } = default!;
        public DbSet<GroupProject.Model.Item> Item { get; set; } = default!;
        public DbSet<GroupProject.Model.Order> Order { get; set; } = default!;
        public DbSet<GroupProject.Model.ShoppingCart> ShoppingCart { get; set; } = default!;
    }
}
