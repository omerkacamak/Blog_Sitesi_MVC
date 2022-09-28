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
    public class SlideBarManager : GenericManager<SlideBar>, ISlideBarService
    {
        ISlideBarDal slideBar;
        public static SlideBarManager Instance => new SlideBarManager( new EfSlideBarDal());
        
        public SlideBarManager(IGenericDal<SlideBar> genericDal) : base(genericDal)
        {
            slideBar = new EfSlideBarDal();
        }


    }
}
