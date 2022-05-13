  #nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tagsekel_administrator.Admin;
using Tagsekel_administrator.Data;

namespace Tagsekel_administrator.Pages.Adminpages
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly Tagsekel_administrator.Data.Tagsekel_administratorContext _context;

        public IndexModel(Tagsekel_administrator.Data.Tagsekel_administratorContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; } 




        public async Task OnGetAsync()
        {
            var Names = from m in _context.Class
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Names = Names.Where(s => s.Name.Contains(SearchString));
            }

            Class = await _context.Class.ToListAsync();
        }
    }
#pragma warning disable CS8618
#pragma warning disable CS8604
}
