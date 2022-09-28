using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datam.Models
{
    public class WriterLikes
    {
        [Key]
        public int WriterLikesID { get; set; }

        [Required]
        public int WriterID { get; set; }
        public Writer Writer { get; set; }
        
        public Blog Blog { get; set; }
        [Required]
        public int BlogID { get; set; }
        public bool LikeType { get; set; }
    }
}
