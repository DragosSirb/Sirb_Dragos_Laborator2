﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sirb_Dragos_Laborator2.Data;
using Sirb_Dragos_Laborator2.Models;

namespace Sirb_Dragos_Laborator2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Sirb_Dragos_Laborator2.Data.Sirb_Dragos_Laborator2Context _context;

        public DetailsModel(Sirb_Dragos_Laborator2.Data.Sirb_Dragos_Laborator2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
