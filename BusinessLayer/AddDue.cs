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
        private DataAccessLayer.Connection connection = new DataAccessLayer.Connection();

        public void AddDues()
        {
            OleDbConnection baglanti = connection.ConnectionOpen();

                DateTime today = DateTime.Now;

                if (today.Day == 1)
                {
                    using (OleDbCommand checkCommand = new OleDbCommand("SELECT COUNT(*) FROM aidat WHERE tarih = ?", baglanti))
                    {
                        checkCommand.Parameters.AddWithValue("?", today.Date);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count == 0)
                        {
                            using (OleDbCommand insertCommand = new OleDbCommand("INSERT INTO aidat (son_odeme, ucret, tarih) VALUES (?, 100, ?)", baglanti))
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

