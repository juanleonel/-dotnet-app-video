using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstAppVideo.Web.Models
{
    public class VideoViewModel
    {
        public int VideoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public int GenreId { get; set; }

        [Display(Name = "Select an genre")]
        public IEnumerable<SelectListItem> Genres { get; set; }
    }
}
