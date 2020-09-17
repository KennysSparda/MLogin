using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_M
{
    class Global
    {
        public static string versao="1.0";
        public static bool logado = false;
        public static int nivel=0;
        public static string local = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string dbname = "mdb.db";
        public static string localdb = local + @"\db\";
    }
}
