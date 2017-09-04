using System;
using System.Data.SqlClient;

namespace SQL_Server_INdepth_Via_Console
{
   class Connection_Cls
    {

        public SqlConnection Connect(string db)
        {
            
            Console.WriteLine(con.State);
            return con;
            con.Close();
        }

    }
}
