using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace BusinessLayer
{
    public class AddDue
    {
        public void AddDues()
        {
            // Access veritabanına bağlanma işlemleri
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Bugünün tarihini al
                DateTime today = DateTime.Now;

                // Eğer bugün ayın 1. günü ise...
                if (today.Day == 1)
                {
                    // Veritabanında bu tarihte bir kayıt olup olmadığını kontrol et
                    using (OleDbCommand checkCommand = new OleDbCommand("SELECT COUNT(*) FROM aidat WHERE tarih = ?", connection))
                    {
                        checkCommand.Parameters.AddWithValue("?", today.Date);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        // Eğer bu tarihte bir kayıt yoksa, yeni bir kayıt ekle
                        if (count == 0)
                        {
                            using (OleDbCommand insertCommand = new OleDbCommand("INSERT INTO aidat (son_odeme, ucret, tarih) VALUES (?, 100, ?)", connection))
                            {
                                insertCommand.Parameters.AddWithValue("?", today.AddMonths(1).Date);
                                insertCommand.Parameters.AddWithValue("?", today.Date);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bu tarihte zaten bir aidat kaydı var.");
                        }
                    }
                }
            }
        }
    }
}
