using System;
using System.Data;
using System.Data.SqlClient;

namespace RealEstate_Profile.DataAccess
{
    class DataAccess
    {


        private static DataAccessException exception;  // Catch bloğu için dataAccessException sınıfını sadece bu classta kulanılacak şekilde static şekilde çağırdık.

        //Sql bağlantısı için 2 tane method tanımı yaptık
        public SqlConnection Connection { get; set; }
        public string ConnectionString { get; set; }



        public DataAccess(string connectionString, ref string error)
        {
            ConnectionString = connectionString;
            try
            {
                Connection = new SqlConnection(connectionString);
                Connection.Open();
            }
            catch (Exception exception)
            {
                error = exception.Message;
            }
        }




        public int ExecuteNonQuery(string sqlQuery, SqlParameter[] sqlParameters, ref DataAccessException exception)
        {
            int result = 0;
            sqlQuery = string.Concat(sqlQuery, "; SELECT ISNULL(SCOPE_IDENTITY(),0) AS LASTID");
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                var sqlCommand = new SqlCommand(sqlQuery, Connection);
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                result = sqlCommand.ExecuteNonQuery();

                Connection.Close();
            }
            catch (Exception ex)
            {
                exception.ErrorDescription = ex.Message;
                exception.ErrorNumber = ex.HResult;

            }
            return result;
        }
        /// <summary>
        /// Geriye tek alanlık bilgi döndüren sql cümleleri için kullanılır. 
        ///<code>SELECT LOGICALREF FROM LG_ITEMS WHERE CODE = 'X'</code>
        /// </summary>
        /// <returns>Return Object Type</returns>
        public object ExecuteScalar(string sqlQuery, SqlParameter[] sqlParameters)
        {
            object result;
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                var sqlCommand = new SqlCommand(sqlQuery, Connection);
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                result = sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                exception.ErrorDescription = ex.Message;
                exception.ErrorNumber = ex.HResult;
                result = null;

            }

            return result;
        }

        public object ExecuteScalar(string sqlQuery)
        {
            object result;
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                var sqlCommand = new SqlCommand(sqlQuery, Connection);

                result = sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                exception.ErrorDescription = ex.Message;
                exception.ErrorNumber = ex.HResult;
                result = null;

            }

            return result;
        }
        /// <summary>
        /// Parametre verilen sql query data table olarak geri döner
        /// </summary>
        /// <param name="sqlQuery">Sql Sorgusu</param>
        /// <param name="sqlParameters">Sorgu içinde kullanılan parametreler</param>
        /// <param name="exception">Hata mesajı</param>
        /// <returns></returns>
        public DataTable GetDataTable(string sqlQuery, SqlParameter[] sqlParameters, ref DataAccessException exception)
        {
            var dataTable = new DataTable();
            try
            {
                exception = new DataAccessException();
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                var sqlCommand = new SqlCommand(sqlQuery, Connection);
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                exception.ErrorDescription = ex.Message;
                exception.ErrorNumber = ex.HResult;
            }

            return dataTable;
        }
        /// <summary>
        /// Sqlden veri kümesi çekmek için kullanılır. SELECT cümlesi ile bir tablodaki tüm veriler gelir.
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public SqlDataReader ExecuteDataReader(string sqlQuery)
        {
            var sqlCommand = new SqlCommand(sqlQuery, Connection);
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }

            }
            catch (Exception ex)
            {
                exception.ErrorDescription = ex.Message;
                exception.ErrorNumber = ex.HResult;
            }


            return sqlCommand.ExecuteReader();
        }

        public SqlDataReader ExecuteDataReader(string sqlQuery, SqlParameter[] sqlParameters)
        {
            var sqlCommand = new SqlCommand(sqlQuery, Connection);
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
            }
            catch (Exception ex)
            {
                exception.ErrorDescription = ex.Message;
                exception.ErrorNumber = ex.HResult;
            }



            return sqlCommand.ExecuteReader();
        }
    }

}