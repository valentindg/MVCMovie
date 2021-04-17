using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;

namespace MVCMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Comments> Comments { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
        public IPagedList PaginatedList { get; set; }
    }
}
