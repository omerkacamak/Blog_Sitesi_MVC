using Data.Models;
using System.Collections.Generic;


namespace Data.AccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog> 
    {
        List<Blog>GetListWithCategory();
        List<Blog>GetListWithCategoryByWriter(int id);
    } 
}