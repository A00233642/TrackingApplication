﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingApplication.Pages.Data
{
    public class CategoryType
    {
        [Key]
        public String Type { get; set; }

        [StringLength(128, MinimumLength = 1)]
        public String Name { get; set; }
    }
}
