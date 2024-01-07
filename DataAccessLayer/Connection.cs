using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DataAccessLayer
{
    public class Connection
    {
        public OleDbConnection ConnectionOpen()
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\90505\\Desktop\\db.accdb;");
            connection.Open();
            return connection;
        }
    }
}
