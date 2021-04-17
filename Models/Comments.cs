using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Comments 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }

        [Display(Name = "Review Date")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
