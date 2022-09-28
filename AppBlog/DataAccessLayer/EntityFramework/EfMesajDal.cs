using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Connection;
using Datam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMesajDal : GenericRepository<Mesaj>, IMesajDal
    {
        public Mesaj getByIDWithWriter(int id)
        {
            using var c = new Context();
            return c.Mesajs.Include(i => i.AliciWriter).Include(x => x.GondWriter).FirstOrDefault(p => p.MesajID == id);
        }
    }
}
