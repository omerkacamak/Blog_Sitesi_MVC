
using Datam.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericDal<Comment>
    {
         List<Comment> GetCommentsBlog(int id);
    }
}