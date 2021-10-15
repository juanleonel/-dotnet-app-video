using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstAppVideo.Domain.Models
{ 
    public class Video
    { 
        [Key]
        public int VideoId { get; set; }

        [Required, StringLength(150)]                
        public string Name { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }
         
        [Column(TypeName = "decimal(8,4)")]
        public decimal Price { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreateAt { get; set; }

        public bool Available { get; set; }

        public Genre Genre { get; set; }

        [ForeignKey("GenreId")]
        public int GenreId { get; set; }
    }

}
