using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    using System.Data;
    using System.Data.SqlClient;

    public abstract class ConnectionToSQL
    {
        private readonly String connectionString;

        public ConnectionToSQL()
        {
            connectionString = "Server=(local); DataBase=CF_BOX_Final; integrated security=true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
