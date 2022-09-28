using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Datam.Models
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterLastName { get; set; }
        public string NickName { get; set; }
        
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public virtual ICollection<Mesaj> AldigiMesajs { get; set; }
        public virtual ICollection<Mesaj> GondMesajs { get; set; }
        public ICollection<Followers> Follower { get; set; }

        public ICollection<Followers> Following { get; set; }
       
    }
}