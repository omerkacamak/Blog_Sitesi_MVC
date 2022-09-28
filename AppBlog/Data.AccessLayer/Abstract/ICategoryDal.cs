using System.Collections.Generic;
using Data.Models;


namespace Data.AccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        List<Category> GetListByBlogs();
        
        
    }
}