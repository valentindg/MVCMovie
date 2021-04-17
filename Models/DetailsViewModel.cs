using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class DetailsViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Comments> Comment { get; set; }
    }
}
