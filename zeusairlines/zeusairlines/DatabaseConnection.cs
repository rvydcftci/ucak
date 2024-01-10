using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace zeusairlines
{
    class DatabaseConnection
    {
        public OleDbConnection Connection () {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\zeusairlines.mdb");
         conn.Open();
         return conn;


        }
    }
}
