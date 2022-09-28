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
    public class FollowersManager : GenericManager<Followers>, IFollowersService
    {
        IFollowersDal followersDal;
        public FollowersManager(IGenericDal<Followers> genericDal) : base(genericDal)
        {
            followersDal = new EfFollowersDal();
        }
    }
}
