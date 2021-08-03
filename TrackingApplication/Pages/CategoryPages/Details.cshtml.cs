using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrackingApplication.Pages.Data;
using TrackingApplication.Pages.Data.Context;

namespace TrackingApplication.Pages.CategoryPages
{
    public class DetailsModel : PageModel
    {
        private readonly TrackingApplication.Pages.Data.Context.StoreContext _context;

        public DetailsModel(TrackingApplication.Pages.Data.Context.StoreContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Categories.FirstOrDefaultAsync(m => m.NameToken == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
