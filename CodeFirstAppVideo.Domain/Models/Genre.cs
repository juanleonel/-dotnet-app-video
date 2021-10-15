using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstAppVideo.Domain.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        public bool Available { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}
