using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datam.Models
{
    public class SlideBar
    {
        [Key]
        public int Id { get; set; }
        public String locationPage { get; set; }
        public String UstBaslik { get; set; }
        public String Content { get; set; }
        public String bgImage { get; set; }
        public String href { get; set; }
    }
}
