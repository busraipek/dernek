using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.OleDb;


namespace BusinessLayer
{
    public class BL_UniqueMember
    {
        private DataAccessLayer.Sender sender;
        public BL_UniqueMember()
        {
            sender = new DataAccessLayer.Sender();
        }
        public void UniqueMember(string[,] duestats, DateTime ilkpicker, DateTime sonpicker, string durumu)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb");
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            try
            {
                string komut;

                if (durumu == "Hepsi")
                {
                    komut = "SELECT u.ad, u.soyad, u.e_posta, u.uyelik_durumu, a.tarih, a.ucret, ad.durum, ad.aidat_id, u.kimlik_no, ad.odeme_tarihi " +
                                     "FROM aidat a, aidat_durum ad, uye u " +
                                     "WHERE a.id=ad.aidat_id AND ad.kimlik_no=u.kimlik_no AND ad.odeme_tarihi between @sonpicker and @ilkpicker ";
                }
                else
                {
                    komut = "SELECT u.ad, u.soyad, u.e_posta, u.uyelik_durumu, a.tarih, a.ucret, ad.durum, ad.aidat_id, u.kimlik_no, ad.odeme_tarihi " +
                                   "FROM aidat a, aidat_durum ad, uye u " +
                                     "WHERE a.id=ad.aidat_id AND ad.kimlik_no=u.kimlik_no AND ad.durum= @durumu AND ad.odeme_tarihi between @sonpicker and @ilkpicker ";
                }
                using (OleDbCommand command = new OleDbCommand(komut, connection))
                {
                    if (durumu != "Hepsi")
                    {
                    command.Parameters.AddWithValue("@durumu", durumu);
                    }
                    command.Parameters.AddWithValue("@ilkpicker", ilkpicker);
                    command.Parameters.AddWithValue("@sonpicker", sonpicker);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            {
                                int i = 0;
                                while (reader.Read())
                                {
                                    DuesStatus duestat = new DuesStatus()
                                    {
                                        ad = reader["ad"].ToString(),
                                        soyad = reader["soyad"].ToString(),
                                        odeme_tarihi = (DateTime)reader["odeme_tarihi"],
                                        durum = reader["durum"].ToString(),
                                        e_posta = reader["e_posta"].ToString(),
                                        tarih = (DateTime)reader["tarih"],
                                        ucret = (int)reader["ucret"],
                                        uyelik_durumu =reader["uyelik_durumu"].ToString(),
                                        aidat_id = (int)reader["aidat_id"],
                                        kimlik_no = reader["kimlik_no"].ToString()

                                    };
                                    duestats[i, 0] = duestat.ad;
                                    duestats[i, 1] = duestat.soyad;
                                    duestats[i, 2] = duestat.ucret.ToString();
                                    duestats[i, 3] = duestat.tarih.ToString("dd/MM/yyyy"); // DateTime'i string'e dönüştür
                                    duestats[i, 4] = duestat.durum;
                                    duestats[i, 5] = duestat.odeme_tarihi.ToString("dd/MM/yyyy");
                                    duestats[i, 6] = duestat.uyelik_durumu;
                                    duestats[i, 7] = duestat.e_posta;
                                    duestats[i, 8] = duestat.aidat_id.ToString();
                                    duestats[i, 9] = duestat.kimlik_no;
                                    i = i + 1;
                                }

                                reader.Close();

                            }
                        }
                    }
                }

            }
            catch
            {

            }
        }
    }
}

