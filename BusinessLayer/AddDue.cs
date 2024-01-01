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
        private BusinessLayer.BL_AddDuetoMember bl_addmember= new BusinessLayer.BL_AddDuetoMember();

        public void AddDues()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                DateTime today = DateTime.Now;

                if (today.Day == 1)
                {
                    using (OleDbCommand checkCommand = new OleDbCommand("SELECT COUNT(*) FROM aidat WHERE tarih = ?", connection))
                    {
                        checkCommand.Parameters.AddWithValue("?", today.Date);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count == 0)
                        {
                            using (OleDbCommand insertCommand = new OleDbCommand("INSERT INTO aidat (son_odeme, ucret, tarih) VALUES (?, 100, ?)", connection))
                            {
                                insertCommand.Parameters.AddWithValue("?", today.AddMonths(1).Date);
                                insertCommand.Parameters.AddWithValue("?", today.Date);
                                insertCommand.ExecuteNonQuery();
                            }
                            bl_addmember.DuetoMember();
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
