using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Common;
using System.Data.SqlClient;

namespace CRM.Dal
{
    public class SqlProvider
    {

        private SqlConnection cnn;
        private SqlCommand cmd;

        public SqlProvider(string commandText,bool isProcedure)
        {
            cnn = new SqlConnection(Tools.ConnectionString);
            cmd = new SqlCommand(commandText,cnn);

            cmd.CommandType = isProcedure ? System.Data.CommandType.StoredProcedure : System.Data.CommandType.Text;


        }

        public void AddParameter(string parameterName,object value)
        {
            cmd.Parameters.AddWithValue(parameterName,value);
        }


        #region ConnectionMethods
        public void OpenConnection()
        {
            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.Open();
            }
        }

        public void CloseConnection()
        {
            if (cnn.State == System.Data.ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        public SqlDataReader ExecuteReader()
        {
            OpenConnection();
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public int ExecuteNonQuery()
        {
            int result = -1;
            try
            {
                OpenConnection();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public object ExecuteScalar()
        {

            object result = -1;
            try
            {
                OpenConnection();
                result = cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }
        #endregion
    }
}
