using Dapper;
using DorksAndDice.Logic.Models.CustomerData;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DorksAndDice.DB.DBAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private string connectionId;
        public string defaultConnectionString = @"Server=localhost\SQLEXPRESS01;Database=DorksAndDice;Trusted_Connection=True;";

        public SqlDataAccess()
        {
            connectionId = defaultConnectionString;
        }

        public SqlDataAccess(string connectionId)
        {
            this.connectionId = connectionId;
        }

        //Return type is going to be the desired model in list form. So all rows that match parameters
        //T is where model class goes. Example is LOAD
        //Parameters is where the query info goes. The stored procedure @Data info goes there
        //USE Dynamic IF THERE ARE NO PARAMETERS AS PARAMETER
        //connectionId is where the SQL database connection goes. Default refers to the one in the json file
        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(connectionId))
            {
                connection.Open();
                var list = await Task.Run(() => connection.QueryAsync<T>(storedProcedure, parameters).Result.ToList());
                connection.Close();
                return list;
            }
        }

        public async Task SaveData<T>(string storedProcedure, T parameters)
        {
            using (IDbConnection conneciton = new SqlConnection(connectionId))
            {
                conneciton.Open();
                await conneciton.ExecuteAsync(storedProcedure, parameters);
                conneciton.Close();
            }
        }

        public void ChangeConnectionString(string connectionString)
        {
            connectionId = connectionString;
        }


    }
}
