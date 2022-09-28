

using Datam.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IWriterDal:IGenericDal<Writer>
    {
        Writer getWriterWithBlogs(int id);
        Writer getWriterWithMessages(int id);
        ICollection<Mesaj> getAllMesajsByWriter(int id);
        List<Writer> GetAllWriterWithRel();
        
    }
}