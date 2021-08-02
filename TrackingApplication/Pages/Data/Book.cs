using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingApplication.Pages.Data
{
    public class Book
    {
        [Key]
        public String ISBN { get; set; }

        public String Title { get; set; }

        public int Category { get; set; }

        public String Author { get; set; }
    }
}
