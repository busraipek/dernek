using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BL_AddMember
    {
        public int boole = 0;
        private DataAccessLayer.Connection baglanti = new DataAccessLayer.Connection();

        public bool BL_FillBar()
        {
            if (boole == 0)
            {
                return false;
            }
            else
                return true;
        }
        public void AddMember(string ad,string soyad,string cins, string kn,DateTime dt,  string kg,string uye, string ep,string sehir)
        {

            OleDbConnection connection = baglanti.ConnectionOpen();

            try
            {
                OleDbCommand komut = new OleDbCommand("insert into uye" +
                "(ad,soyad,cinsiyet,kimlik_no,dogum_tarihi,kan_grubu," +
                "uyelik_durumu,e_posta,sehir) values (@ad, @soyad, @cinsiyet, @kimlik_no, @dogum_tarihi, @kan_grubu, " +
                "@uyelik_durumu,@e_posta,@sehir)", connection);

                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@cinsiyet", cins);
                komut.Parameters.AddWithValue("@kimlik_no", kn);
                komut.Parameters.AddWithValue("@dogum_tarihi", dt);
                komut.Parameters.AddWithValue("@kan_grubu", kg);
                komut.Parameters.AddWithValue("@uyelik_durumu", uye);
                komut.Parameters.AddWithValue("@e_posta", ep);
                komut.Parameters.AddWithValue("@sehir", sehir);
                komut.ExecuteNonQuery();
                boole = 1;
                BL_FillBar();
            }
            catch (Exception)
            {
            
            }
             connection.Close();
        }

    }
}
