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
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public ICollection<Mesaj> getAllMesajsByWriter(int id)
        {
           Writer kisi = getWriterWithMessages(id);
            ICollection<Mesaj> liste1 = kisi.GondMesajs;
            ICollection<Mesaj> liste2 = kisi.AldigiMesajs;
            ICollection<Mesaj> liste3 = liste1.Concat(liste2).ToList();
            return liste3;

        }

        public List<Writer> GetAllWriterWithRel()
        {
            using var c = new Context();
            return c.Writers.Include(i => i.Roles).Include(i => i.Blogs).ThenInclude(k => k.Category)
                .Include(z => z.Following).ThenInclude(q => q.Writerim).ThenInclude(c => c.Blogs).ThenInclude(v => v.Category)
                .Include(x => x.Follower).ThenInclude(q => q.Follower).ToList();
        }

        public Writer getWriterWithBlogs(int id)
        {
            using var c = new Context();
            return c.Writers.Include(i => i.Blogs).ThenInclude(k=>k.Category).Include(z=>z.Following).ThenInclude(q => q.Writerim).ThenInclude(c=>c.Blogs).ThenInclude(v=>v.Category).Include(x=>x.Follower).ThenInclude(q=>q.Follower).FirstOrDefault(x => x.WriterID == id);
        }

        public Writer getWriterWithMessages(int id)
        {
            using var c = new Context();
            return c.Writers.Include(i=>i.AldigiMesajs).Include(x=>x.GondMesajs).FirstOrDefault(x=>x.WriterID == id);
        }
    }
}
