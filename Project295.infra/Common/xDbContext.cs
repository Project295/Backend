using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
using System.Data;
using Project295.Core.Common;

namespace Project295.Infra.Common
{
    public class xDbContext : IDbContext
    {
        private DbConnection _connection;
        private readonly IConfiguration _configuration;

        public xDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(
                        _configuration["ConnectionStrings:DBConnectionString"]
                    );
                    _connection.Open();
                }
                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }
    }
}
