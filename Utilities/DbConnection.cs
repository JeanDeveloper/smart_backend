using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Utilities
{
    public class DbConnection
    {

        public static SqlConnection getConnection()
        {
            return new SqlConnection(Startup.Configuration.GetSection("ConnectionString").Value);
        }

    }
}
