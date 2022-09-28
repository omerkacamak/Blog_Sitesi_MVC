using Data.Services.Abstract;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _efCategoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _efCategoryDal = categoryDal;
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            return _efCategoryDal.GetListAll();
        }

        public List<Category> GetListAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category GetOne1(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Category t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> tumListe()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
