﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using recruitcatturannu.Data;
using recruitcatturannu.NewFolder;

namespace recruitcatturannu.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly recruitcatturannu.Data.recruitcatturannuContext _context;

        public DetailsModel(recruitcatturannu.Data.recruitcatturannuContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .Include(x=>x.Company)
                .Include(y=>y.Industry)
                .Include(z=>z.JobTitle)
                .FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null)
            {
                return NotFound();
            }
            else
            {
                Candidate = candidate;
            }
            return Page();
        }
    }
}
