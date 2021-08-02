using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingApplication.Pages;


namespace TrackingApplication.Pages.Data.Context
{
    public class StoreContext
        :DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
          : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryType> CategoryTypes { get; set; }
    }
}
