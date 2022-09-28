using Data.Services.Abstract;
using Data.Services.Concrete;
using DataAccessLayer.Abstract;
using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.EntityManager
{
    public class WriterLikesManager : GenericManager<WriterLikes>, IWriterLikesService
    {
        
        public WriterLikesManager(IGenericDal<WriterLikes> genericDal) : base(genericDal)
        {
        }
    }
}
