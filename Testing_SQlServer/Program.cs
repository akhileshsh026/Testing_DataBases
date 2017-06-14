using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Testing_SQlServer
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlTransaction t1 = null;
            SqlConnection con = new SqlConnection("Data Source=localhost;DataBase=DimX;Integrated Security=true");
            con.Open();
            t1 = con.BeginTransaction();
           
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = String.Format("Select * from Employee");
            DataTable dt = new DataTable();
            t1.Commit();   // important this methord before the execution methord.
            dt.Load(cmd.ExecuteReader());
            


            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Records Facthed Sucessfully");
                Console.WriteLine("\n \n \n \n **********************************************************");
                foreach (DataRow item in dt.Rows)
                {
                    Console.WriteLine(string.Join("\t", item.ItemArray));
                }
            }
            else
            {
                Console.WriteLine("Records afrfe not inserted sucessfully");
                t1.Rollback();
            }


            con.Close();

        }
    }
}
