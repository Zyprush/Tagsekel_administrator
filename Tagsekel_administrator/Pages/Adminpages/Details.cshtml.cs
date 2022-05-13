#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tagsekel_administrator.Admin;
using Tagsekel_administrator.Data;

namespace Tagsekel_administrator.Pages.Adminpages
{
    public class DetailsModel : PageModel
    {
        private readonly Tagsekel_administrator.Data.Tagsekel_administratorContext _context;

        public DetailsModel(Tagsekel_administrator.Data.Tagsekel_administratorContext context)
        {
            _context = context;
        }

        public Class Class { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.FirstOrDefaultAsync(m => m.ID == id);

            if (Class == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
