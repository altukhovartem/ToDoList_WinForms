using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccess
{
    class DapperConnection : IDataConnection
    {
        private const string ConnectionString = "conStr";

        public void AddNewTask()
        {
            TaskModel taskModel = new TaskModel
            {
                Title = "Task",
                Description = "TestTask1"
            };


            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnectionString(ConnectionString)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Title", taskModel.Title);
                p.Add("@Description", taskModel.Description);
                p.Add("@Description", taskModel.Description);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                int currentId = connection.Execute("[dbo].[TaskModel_Insert]", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
