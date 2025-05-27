using Klinik.DAL.Context;
using Klinik.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik.DAL.Efcore
{
    public class AboutDal
    {
        private readonly ProjeContext _context;

        public AboutDal()
        {
            _context = new ProjeContext();
        }

        public List<About> GetAll()
        {
            var about = _context.abouts.ToList();
            return about;
        }
    }
}
