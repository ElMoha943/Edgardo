using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Edgardo
{
    public abstract class DB
    {
        private readonly string connectionstring = "Server=(local); DataBase = dashboard; Integrated Security=true" ;

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
