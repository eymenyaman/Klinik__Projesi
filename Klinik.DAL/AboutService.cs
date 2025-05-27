using Klinik.DAL.Efcore;
using Klinik.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik.BLL
{
    public class AboutService
    {
        private readonly AboutDal _aboutDal;

        public AboutService()
        {
            _aboutDal = new AboutDal();
        }
        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }
    }
}
