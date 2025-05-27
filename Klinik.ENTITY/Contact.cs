using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik.ENTITY
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Telefon numarası boş bırakılamaz.")]
        [RegularExpression(@"^0[0-9]{10}$", ErrorMessage = "Telefon numarası 0 ile başlamalı ve 11 haneli olmalıdır.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-posta adresi boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string X { get; set; }
        public string Linkedin { get; set; }

    }
}
