using System;
using System.Data;
using System.Data.SqlClient;
using Ns_Constants;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Configuration;

namespace Ns_DataAccess
{
    public class SQL_DataAccess
    {
        public static string ConnectionString()
        {
            string connstring = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            return connstring;
        }

        public bool ExecuteSQL(string sSQL)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            SqlTransaction sqlTransaction = null;
            //sErr = "";
            try
            {
                try
                {
                    sqlConnection = new SqlConnection()
                    {
                        ConnectionString = string.Concat(ConnectionString(), "Connect Timeout=30")
                    };
                    sqlConnection.Open();
                    sqlTransaction = sqlConnection.BeginTransaction();
                    sqlCommand = new SqlCommand(sSQL, sqlConnection, sqlTransaction);
                    sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                }
                catch (Exception)
                {
                    /*ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					sErr = string.Concat(exception.Source, " ", exception.Message);
					num = 1;
					ProjectData.ClearProjectError();
					return num;*/
                }
            }
            finally
            {
                sqlCommand.Dispose();
                sqlConnection.Dispose();
                sqlTransaction.Dispose();
                sqlCommand = null;
                sqlConnection = null;
                sqlTransaction = null;
            }

            return true;
        }

        public DataSet GetDataSet(string sSQL)
        {
            SqlConnection cnn;
            SqlDataAdapter dad;
            DataSet dts = new DataSet();
            cnn = new SqlConnection(ConnectionString());
            dad = new SqlDataAdapter(sSQL, cnn);
            try
            {
                cnn.Open();
                dad.Fill(dts);
                cnn.Close();

                return dts;
            }
            catch (Exception)
            {

                return dts;
            }
            finally
            {
                dad.Dispose();
                cnn.Dispose();
                dts = null;
                cnn = null;
            }
        }
    }
}