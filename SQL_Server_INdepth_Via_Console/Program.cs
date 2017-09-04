using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Server_INdepth_Via_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection_Cls obj = new Connection_Cls();
            obj.Connect("Company");
            
        }
    }
}
