using Klinik.DAL.Efcore;
using Klinik.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik.BLL
{
    public class DoctorService
    {
        private readonly DoctorDal _doctorDal;
        public DoctorService()
        {
            _doctorDal = new DoctorDal();
        }

        public List<Doctor> GetAll()
        {
            return _doctorDal.GetAll();
        }

    }
}
