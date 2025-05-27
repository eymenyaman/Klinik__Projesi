using Klinik.DAL.Context;
using Klinik.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik.DAL.Efcore
{
    public class DoctorDal
    {
        private readonly ProjeContext _context;

        public DoctorDal()
        {
            _context = new ProjeContext();
        }

        public List<Doctor> GetAll()
        {
            var doctors = _context.doctors.ToList();
            return doctors;
        }

    }
}
