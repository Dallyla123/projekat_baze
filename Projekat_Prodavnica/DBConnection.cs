using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_Prodavnica
{
    internal class DBConnection
    {
        public string MyConection()
        {
            string con = "Data Source=SQL8001.site4now.net;Initial Catalog=db_a85806_prodavnicadb;User Id=db_a85806_prodavnicadb_admin;Password=onlinebaza2";
            return con;
        }
    }
}
