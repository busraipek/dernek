using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BL_DueList
    {
        public void GetDues(string[,] dues)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb");
            {
                connection.Open();

                string query = "SELECT id, tarih, ucret, son_odeme FROM aidat";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            Due due = new Due()
                            {
                                aidat_id = (int)reader["id"],
                                ucret = (int)reader["ucret"],
                                tarih = (DateTime)reader["tarih"],
                                son_odeme = (DateTime)reader["son_odeme"]
                            }; 
                            dues[i, 3] = due.aidat_id.ToString();
                            dues[i, 0] = due.ucret.ToString();
                            dues[i, 1] = due.tarih.ToString("dd/MM/yyyy");
                            dues[i, 2] = due.son_odeme.ToString("dd/MM/yyyy");
                            i = i + 1;
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
