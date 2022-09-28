﻿using Datam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Abstract
{
    public interface IMesajService:IGenericService<Mesaj>
    {
        Mesaj getByIDWithWriter1(int id);
    }
}