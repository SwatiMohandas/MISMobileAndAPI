using System.Data.SqlClient;

namespace MobileWebAPI.DAL
{
    public class DataConnection
    {
        public SqlConnection GetConnection()
        {
            string connectionString = GetConnectionString();
            return new SqlConnection(connectionString);
        }

        public string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            return configuration.GetValue<string>("ConnectionString:ApplicationServices");
        }

        public SqlConnection GetConnectionMIS()
        {
            string connectionString = GetConnectionStringMIS();
            return new SqlConnection(connectionString);
        }

        public string GetConnectionStringMIS()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            return configuration.GetValue<string>("ConnectionString:ApplicationServicesMIS");
        }
    }
}
