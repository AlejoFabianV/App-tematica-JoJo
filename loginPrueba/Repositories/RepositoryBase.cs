using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Markup;

namespace loginPrueba.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase() 
        {
            _connectionString = "Server=(local); Database=LoginJoJoDB; Integrated Security=true";
        }
        protected SqlConnection GetConecction() 
        {
            return new SqlConnection(_connectionString);
        }

    }
}
