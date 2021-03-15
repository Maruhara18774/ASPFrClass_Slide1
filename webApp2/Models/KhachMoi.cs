using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace webApp2.Models
{
    public class KhachMoi
    {
        // Fields
        private string ten;
        private string sdt;
        private string email;
        private bool xacNhanThamGia;

        // Get set
        [Required(ErrorMessage ="Xin nhập tên")]
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public bool XacNhanThamGia { get => xacNhanThamGia; set => xacNhanThamGia = value; }

        public KhachMoi() { }
    }
}