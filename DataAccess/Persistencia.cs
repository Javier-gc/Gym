namespace DataAccess
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class Persistencia : ConnectionToSQL
    {
        public int SiguienteID(string tableName, string idField)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    int val;
                    command.Connection = connection;
                    command.CommandText = "select Max(" + idField + ") FROM " + tableName;
                    object maxValue = command.ExecuteScalar();
                    connection.Close();

                    if (maxValue == DBNull.Value)
                    {
                        return 1;
                    }
                    else
                    {
                        val = int.Parse((maxValue).ToString());
                        return val + 1;
                    }
                }
            }
        }
    }
}
