using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BL_CityList
    {
        public void GetCities(List<string> cities)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb");
            {
                connection.Open();

                string query = "SELECT sehir FROM sehir";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            City city = new City()
                            {
                                sehir = reader["sehir"].ToString(),
                            };

                            cities.Add(city.sehir.ToString()) ;
                        }
                    }
                }
            }
        }
    }
}
