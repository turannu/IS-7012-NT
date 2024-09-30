using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GroupProject.Data;
using GroupProject.Model;

namespace GroupProject.Pages.ShoppingCarts
{
    public class IndexModel : PageModel
    {
        private readonly GroupProject.Data.GroupProjectContext _context;

        public IndexModel(GroupProject.Data.GroupProjectContext context)
        {
            _context = context;
        }

        public IList<ShoppingCart> ShoppingCart { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ShoppingCart = await _context.ShoppingCart
                .Include(s => s.Customers)
                .Include(s => s.Orders).ToListAsync();
        }
    }
}
