using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Connection;
using Datam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetAllWithCatWri()
        {
            using var c = new Context();
            return c.Blogs.Include(i => i.Writer).Include(c => c.Category).OrderByDescending(i=>i.BlogCreateDate).ToList();
        }

        public List<Blog> GetAllWithCatWri(Expression<Func<Blog, bool>> filter)
        {
            using var c = new Context();
            return c.Blogs.Include(i => i.Writer).Include(c => c.Category).Where(filter).ToList();
        }

        public List<Blog> GetBlogsDiffCat()
        {
            using var c = new Context();
            //var query = ";WITH cte AS (SELECT *,ROW_NUMBER() OVER (PARTITION BY CategoryID ORDER BY BlogID desc) AS rn from Blogs)" +
            //    "Select * FROM cte where rn=1";


            return c.Blogs.ToList();
        }

        public List<Blog> GetPopularBlogs()
        {
            using var c = new Context();
            return c.Blogs.Include(i => i.Writer).ThenInclude(z=>z.Blogs).ThenInclude(m=>m.Category).Include(i => i.Category).OrderByDescending(c => c.Begeni).ToList();
        }
    }
}
