
using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog> 
    {
        List<Blog> GetAllWithCatWri();
        List<Blog> GetAllWithCatWri(Expression<Func<Blog, bool>> filter);
        List<Blog> GetPopularBlogs();
        List<Blog> GetBlogsDiffCat();
        
        
    } 
}