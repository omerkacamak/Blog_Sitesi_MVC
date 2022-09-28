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
    public class MesajManager : GenericManager<Mesaj>, IMesajService
    {
        IMesajDal mesajDal;
        public MesajManager(IGenericDal<Mesaj> genericDal) : base(genericDal)
        {
            mesajDal = new EfMesajDal();
        }

        public Mesaj getByIDWithWriter1(int id)
        {
            return mesajDal.getByIDWithWriter(id);
        }
    }
}
