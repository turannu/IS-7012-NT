using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using recruitcatturannu.Data;
using recruitcatturannu.NewFolder;

namespace recruitcatturannu.Pages.Shared.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly recruitcatturannu.Data.recruitcatturannuContext _context;

        public CreateModel(recruitcatturannu.Data.recruitcatturannuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyID", "CompanyName");
        ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "IndustryName");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Description");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
