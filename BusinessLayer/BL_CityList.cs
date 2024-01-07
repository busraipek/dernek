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
        private DataAccessLayer.Connection baglanti = new DataAccessLayer.Connection();

        public void GetCities(List<string> cities)
        {
            OleDbConnection connection = baglanti.ConnectionOpen();

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
