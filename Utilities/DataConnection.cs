using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class DataConnection
    {
        private readonly IConfiguration configuration;
        private string connectionString;

        public SqlConnection GetConnection()
        {
            //string connectionString = DataConnections();
            //return new SqlConnection("Server=10.200.40.24;User ID=sa;Password=123asd.;Database=REPORTTHAI2023_24;TrustServerCertificate=true;Trusted_Connection=true;Integrated Security=false;");
            return new SqlConnection("Server=10.200.90.20;User ID=mis;Password=thai@123;Database=REPORTTHAI2023_24;TrustServerCertificate=true;Trusted_Connection=true;Integrated Security=false;");
        }

        public string DataConnections()
        {
            //this.configuration = configuration;
            return connectionString = "Server=10.200.40.24;User ID=sa;Password=123asd.;Database=REPORTTHAI2023_24;TrustServerCertificate=true;Trusted_Connection=true;Integrated Security=false;";
        }

    }

    public class DataConnectionMIS
    {
        private readonly IConfiguration configuration;
        private string connectionString;

        public SqlConnection GetConnection()
        {
            //string connectionString = DataConnections();
            return new SqlConnection("Server=10.200.90.20;User ID=mis;Password=thai@123;Database=MISCredential;TrustServerCertificate=true;Trusted_Connection=true;Integrated Security=false;");
        }
    }
}
