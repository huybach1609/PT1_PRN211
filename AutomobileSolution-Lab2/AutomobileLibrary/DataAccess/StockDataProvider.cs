using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace AutomobileLibrary.DataAccess
{
    public class StockDataProvider
    {
        private string ConnectionString { get; set; }
        public StockDataProvider(string connectionString) => ConnectionString = connectionString;
        public void CloseConnection(SqlConnection connection) => connection.Close();


        public DataTable GetDataBySql(String sql)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataBySql(string sql, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            //1. create cmd (sql, connection)
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                // 2. add parameters
                cmd.Parameters.AddRange(parameters);
                // 3. add cmd to adapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // 4. add data from adapter to datatable
                DataTable result = new DataTable();
                adapter.Fill(result);
                return result;
            }

        }
        public int ExecuteNoneQuery(string sql, SqlParameter[] parameters)
        {
            DataTable dt = GetDataBySql(sql, parameters);
            return dt.Rows.Count;
        }


    }
}