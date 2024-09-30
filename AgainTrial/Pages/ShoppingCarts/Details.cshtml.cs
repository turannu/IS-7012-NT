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
    public class DetailsModel : PageModel
    {
        private readonly AgainTrial.Data.AgainTrialContext _context;

        public DetailsModel(AgainTrial.Data.AgainTrialContext context)
        {
            _context = context;
        }

        public ShoppingCart ShoppingCart { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingcart = await _context.ShoppingCart.FirstOrDefaultAsync(m => m.ShoppingCartId == id);
            if (shoppingcart == null)
            {
                return NotFound();
            }
            else
            {
                ShoppingCart = shoppingcart;
            }
            return Page();
        }
    }
}
