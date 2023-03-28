using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DorksAndDice.DB.DBAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        //Return type is going to be the desired model in list form. So all rows that match parameters
        //Parameters is where the query info goes. The stored procedure @Data info goes there
        //connectionId is where the SQL database connection goes. Default refers to the one in the json file
        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default")
        {
            using IDbConnection conneciton = new SqlConnection(_config.GetConnectionString(connectionId));

            return await conneciton.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default")
        {
            using IDbConnection conneciton = new SqlConnection(_config.GetConnectionString(connectionId));

            await conneciton.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

    }
}
