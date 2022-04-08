using System;
using System.Data;
using System.Data.OleDb;

namespace RealEstate_Profile.DataAccess
{
    class OleDbDataAccess
    {

        private static DataAccessException exception;  // Catch bloğu için dataAccessException sınıfını sadece bu classta kulanılacak şekilde static şekilde çağırdık.


        public string ConnectionString { get; set; }
        public OleDbConnection OleDbConnection { get; set; }


        public OleDbDataAccess(string connectionString, ref string error)
        {
            ConnectionString = connectionString;
            try
            {
                OleDbConnection = new OleDbConnection(connectionString);
                OleDbConnection.Open();
            }
            catch (Exception exception)
            {
                error = exception.Message;
            }
        }
        public OleDbDataReader ExecuteDataReader(string sqlQuery)
        {
            var sqlCommand = new OleDbCommand(sqlQuery, OleDbConnection);
            try
            {
                if (OleDbConnection.State != ConnectionState.Open)
                {
                    OleDbConnection.Open();
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
