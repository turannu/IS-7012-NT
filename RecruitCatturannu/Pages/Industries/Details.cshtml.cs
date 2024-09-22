using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using recruitcatturannu.Data;
using recruitcatturannu.NewFolder;

namespace recruitcatturannu.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly recruitcatturannu.Data.recruitcatturannuContext _context;

        public DetailsModel(recruitcatturannu.Data.recruitcatturannuContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry
                .Include(x => x.Candidates)
                .Include(y=>y.Companies)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (industry == null)
            {
                return NotFound();
            }
            else
            {
                Industry = industry;
            }
            return Page();
        }
    }
}
