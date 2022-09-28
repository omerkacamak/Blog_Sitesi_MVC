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
    public class WriterManager : GenericManager<Writer>, IWriterService
    {
        IWriterDal writerDal;
        public WriterManager(IGenericDal<Writer> genericDal) : base(genericDal)
        {
           writerDal=new EfWriterDal();
        }

        public ICollection<Mesaj> getAllMesajsByWriter1(int id)
        {
            return writerDal.getAllMesajsByWriter(id);
        }

        public List<Writer> GetAllWriterWithRel1()
        {
            return writerDal.GetAllWriterWithRel();
        }

        public Writer GetWriterWithBlog1(int id)
        {
            return writerDal.getWriterWithBlogs(id);
        }

        public Writer GetWriterWithMessages1(int id)
        {
            return writerDal.getWriterWithMessages(id);
        }
    }
}
