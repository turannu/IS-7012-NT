using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgainTrial.Data;
using AgainTrial.Model;

namespace AgainTrial.Pages.ShoppingCarts
{
    public class IndexModel : PageModel
    {
        private readonly AgainTrial.Data.AgainTrialContext _context;

        public IndexModel(AgainTrial.Data.AgainTrialContext context)
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
