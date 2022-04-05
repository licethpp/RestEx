using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rest2.Models
{
    public class Sterrenbeeld
    {
       
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public DateTime Dag { get; private set; }
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public DateTime Maand { get; private set; }

    }
}
