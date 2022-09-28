using System.ComponentModel.DataAnnotations;

namespace Datam.Models
{
    public class NewsLetter
    {
        [Key]
        public int MailID { get; set; }
        public string Mail { get; set; }
        public bool MailStatus { get; set; }
    }
}