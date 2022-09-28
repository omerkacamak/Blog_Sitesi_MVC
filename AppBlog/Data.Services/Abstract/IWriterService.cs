using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IWriterService:IGenericService<Writer>
    {
        Writer GetWriterWithBlog1(int id);
        Writer GetWriterWithMessages1(int id);
        ICollection<Mesaj> getAllMesajsByWriter1(int id);
        List<Writer> GetAllWriterWithRel1();
    }
}
