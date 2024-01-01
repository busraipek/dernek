using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.OleDb;

namespace BusinessLayer
{
    public class BL_AddDuetoMember
    {
        private DataAccessLayer.Due bl_dues;
        public BL_AddDuetoMember()
        {
            bl_dues = new DataAccessLayer.Due();

        }

        public void DuetoNewMember(string kimlik, string durum)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb");
            {

                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT max(id) as id from aidat", connection);
                {
                    using (OleDbDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int aidat_id = (int)reader["id"];

                            OleDbCommand komut = new OleDbCommand("insert into aidat_durum (aidat_id,kimlik_no,durum) values (@aidat_id,@kimlik_no,@durum)", connection);
                            {
                                komut.Parameters.AddWithValue("@aidat_id", aidat_id);
                                komut.Parameters.AddWithValue("@kimlik_no", kimlik);
                                komut.Parameters.AddWithValue("@durum", durum);
                                komut.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
        public void DuetoMember()
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb");
            {

                connection.Open();
                OleDbCommand query = new OleDbCommand("SELECT max(id) as id from aidat", connection);
                {
                    using (OleDbDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int aidat_id = (int)reader["id"];
                            OleDbCommand komut = new OleDbCommand("SELECT kimlik_no from uye", connection);
                            {
                                using (OleDbDataReader read = komut.ExecuteReader())
                                {
                                    int i = 0;
                                    while (read.Read())
                                    {

                                        OleDbCommand query2 = new OleDbCommand("insert into aidat_durum (aidat_id,kimlik_no,durum) values (@aidat_id,@kimlik_no,@durum)", connection);
                                        {
                                            query2.Parameters.AddWithValue("@aidat_id", aidat_id);
                                            query2.Parameters.AddWithValue("@kimlik_no", read["kimlik_no"].ToString());
                                            query2.Parameters.AddWithValue("@durum", "Ödenmedi");
                                            query2.ExecuteNonQuery();
                                        }
                                        i = i + 1;
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}
    

