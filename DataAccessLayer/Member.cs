using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Member
    {
        public string kimlik_no { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cinsiyet { get; set; }
        public DateTime dogum_tarihi { get; set; }
        public string kan_grubu { get; set; }
        public string uyelik_durumu { get; set; }
        public string e_posta { get; set; }
        public string sehir { get; set; }
    }
}
