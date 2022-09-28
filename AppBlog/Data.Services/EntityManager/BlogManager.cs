using Data.Services.Abstract;
using Data.Services.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.EntityManager
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        public static BlogManager Instance => new BlogManager(new EfBlogDal());
        IBlogDal blogDal;
        public BlogManager(IGenericDal<Blog> genericDal) : base(genericDal)
        {
            blogDal = new EfBlogDal();
        }

        public List<Blog> GetAllWithCatWri1()
        {
            return blogDal.GetAllWithCatWri();
        }

        public List<Blog> GetAllWithCatWri1(Expression<Func<Blog, bool>> filter)
        {
            return blogDal.GetAllWithCatWri(filter);

        }

        public List<Blog> GetPopularBlogs1()
        {
            return blogDal.GetPopularBlogs();
        }

        public List<Blog> GetBlogsDiffCat1()
        {
            return blogDal.GetBlogsDiffCat();
        }
    }
}
