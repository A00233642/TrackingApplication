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
    public class IndexModel : PageModel
    {
        private readonly TrackingApplication.Pages.Data.Context.StoreContext _context;

        public IndexModel(TrackingApplication.Pages.Data.Context.StoreContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
