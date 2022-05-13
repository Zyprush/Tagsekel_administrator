#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tagsekel_administrator.Admin;
using Tagsekel_administrator.Data;

namespace Tagsekel_administrator.Pages.Adminpages
{
#pragma warning disable CS8618
#pragma warning disable CS8602
    public class CreateModel : PageModel
    {
        private readonly Tagsekel_administrator.Data.Tagsekel_administratorContext _context;

        public CreateModel(Tagsekel_administrator.Data.Tagsekel_administratorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Class Class { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Class.Add(Class);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
#pragma warning disable CS8618
#pragma warning disable CS8602
}
