using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{  // GenericRepository ile ortakları alıyor ICategoryDal ise farklılıklar var ise ekleniyor.
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
    }
}
