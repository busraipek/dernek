using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.OleDb;
using System.Windows.Documents;

namespace BusinessLayer
{
    public class BL_SendEmail
    {
        private DataAccessLayer.Connection baglanti = new DataAccessLayer.Connection();
        private DataAccessLayer.Sender sender;
            public BL_SendEmail()
            {
                sender = new DataAccessLayer.Sender();
            }
            public void SendMail(List<string> list, string baslik, string konu)
            {
            OleDbConnection connection = baglanti.ConnectionOpen();

                string query = "SELECT u.e_posta FROM aidat a, aidat_durum ad, uye u where a.id=ad.aidat_id and ad.kimlik_no=u.kimlik_no and ad.durum = 'Ödenmedi' and u.uyelik_durumu= 'Aktif' ";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DuesStatus posta = new DuesStatus()
                            {
                                e_posta = reader["e_posta"].ToString(),
                            };

                            list.Add(posta.e_posta.ToString());
                        }
                    }
                }
            

            SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential(sender.senderEmail, sender.senderpassword);
                smtp.Host = sender.smtphost;
                smtp.Port = sender.smtpport;
                smtp.EnableSsl = true;
                sender.baslik = baslik;
                sender.konu = konu;
            foreach(var posta in list)
            {
                MailMessage message = new MailMessage(sender.senderEmail, posta, baslik, konu);
                smtp.Send(message);
            }

            }
        }
    }

