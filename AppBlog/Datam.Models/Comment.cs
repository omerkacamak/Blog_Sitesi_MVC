using System;
using System.ComponentModel.DataAnnotations;

namespace Datam.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public int WriterID { get; set; }
        public Writer Writer { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
       
    }

    
}