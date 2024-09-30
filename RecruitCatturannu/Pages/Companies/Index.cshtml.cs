﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using recruitcatturannu.Data;
using recruitcatturannu.NewFolder;

namespace recruitcatturannu.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly recruitcatturannu.Data.recruitcatturannuContext _context;

        public IndexModel(recruitcatturannu.Data.recruitcatturannuContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry).ToListAsync();
        }
    }
}