using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BL_UpdateDue
    {
        public void UpdateDue(string[,] dues,string id, string picker, string ucret)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb");
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            try
            {
                int idd = Convert.ToInt32(id);
                string komut = "select * from aidat where id= " + idd + "";
                using (OleDbCommand command = new OleDbCommand(komut, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            string query = "UPDATE aidat SET ucret= " + ucret + " , son_odeme= '" + picker + "' WHERE id = " + idd + "";
                            using (OleDbCommand comm = new OleDbCommand(query, connection))
                            {
                                using (OleDbDataReader read = comm.ExecuteReader())
                                {
                                    Due due = new Due()
                                    {
                                        aidat_id = (int)read["id"],
                                        tarih = (DateTime)read["tarih"],
                                        son_odeme = (DateTime)read["son_odeme"],
                                        ucret = (int)read["ucret"]
                                    };

                                    dues[i, 0] = due.ucret.ToString();
                                    dues[i, 1] = due.tarih.ToString();
                                    dues[i, 3] = due.aidat_id.ToString();
                                    dues[i, 2] = due.son_odeme.ToString("dd/MM/yyyy"); // DateTime'i string'e dönüştür

                                    i = i + 1;
                                }
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
