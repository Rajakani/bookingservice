using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCoreApp.Models
{
    public partial class Movie
    {
        [Key]
        public long Key { get; set; }
      
        public string Name { get; set; }
        public int Availability { get; set; } = 100;

        internal virtual Cinema Cinema { get; set; }                
    }
}