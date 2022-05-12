﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P224Allup.Models
{
    public class Size
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<ProductColorSize> ProductColorSizes { get; set; }
    }
}
