using Data.Services.Abstract;
using Data.Services.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.EntityManager
{
    public class CommentManager : GenericManager<Comment>, ICommentService
    {
        ICommentDal commentDal;
        public CommentManager(IGenericDal<Comment> genericDal) : base(genericDal)
        {
            commentDal = new EfCommentDal();
        }

        public List<Comment> GetCommentsBlog1(int id)
        {
            return commentDal.GetCommentsBlog(id);
        }
    }
}
