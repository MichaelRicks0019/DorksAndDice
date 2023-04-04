﻿using Dapper;
using DorksAndDice.Logic.Models.CustomerData;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DorksAndDice.DB.DBAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly string connectionString = "Server=localhost\\SQLEXPRESS01;Database=DorksAndDice;Trusted_Connection=True;";

        public SqlDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Return type is going to be the desired model in list form. So all rows that match parameters
        //T is where model class goes. Example is LOAD
        //Parameters is where the query info goes. The stored procedure @Data info goes there
        //USE Dynamic IF THERE ARE NO PARAMETERS AS PARAMETER
        //connectionId is where the SQL database connection goes. Default refers to the one in the json file
        public async Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Server=localhost\\SQLEXPRESS01;Database=DorksAndDice;Trusted_Connection=True;")
        {
            using (IDbConnection conneciton = new SqlConnection(connectionString))
            {
                var list = await Task.Run(() => conneciton.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList());
                return list;
            }
        }

        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default")
        {
            using IDbConnection conneciton = new SqlConnection(connectionString);
            await conneciton.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }


    }
}
