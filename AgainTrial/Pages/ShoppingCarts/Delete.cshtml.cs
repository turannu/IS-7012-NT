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
    public class DeleteModel : PageModel
    {
        private readonly AgainTrial.Data.AgainTrialContext _context;

        public DeleteModel(AgainTrial.Data.AgainTrialContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingcart = await _context.ShoppingCart.FindAsync(id);
            if (shoppingcart != null)
            {
                ShoppingCart = shoppingcart;
                _context.ShoppingCart.Remove(ShoppingCart);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
