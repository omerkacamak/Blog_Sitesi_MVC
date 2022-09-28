using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMesajDal:IGenericDal<Mesaj>
    {
        Mesaj getByIDWithWriter(int id);
    }
}
