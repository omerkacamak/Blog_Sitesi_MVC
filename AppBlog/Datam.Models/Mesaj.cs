using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datam.Models
{
    public class Mesaj
    {
        [Key]
        public int MesajID { get; set; }
        public string Content { get; set; }
        
        public int? GondericiID { get; set; }
        
        public int? AliciId { get; set; }
        public Writer GondWriter { get; set; }
        public Writer AliciWriter { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
