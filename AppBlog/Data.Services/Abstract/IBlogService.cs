using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetAllWithCatWri1();
        List<Blog> GetAllWithCatWri1(Expression<Func<Blog, bool>> filter);
        List<Blog> GetPopularBlogs1();
        List<Blog> GetBlogsDiffCat1();


    }
}
