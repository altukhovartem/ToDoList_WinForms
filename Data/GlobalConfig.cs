using Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; set; }
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static void InitializeConnection(ConnectionTypes type)
        {
            if(type == ConnectionTypes.Dapper)
            {
                Connection = new DapperConnection();
            }
        }
    }
}
