using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaseDAL
    {
        public FStoreDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        public BaseDAL()
        {
            var connectionString = GetConnection();
            dataProvider = new FStoreDataProvider(connectionString);
        }
        public string GetConnection()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appconfigs.json", true, true).Build();
            connectionString = config["ConnectionString:MyFStoreDB"];
            return connectionString;
        }
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}
