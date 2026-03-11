using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class DBManager
    {
        SqlConnection sqlcn;
        SqlCommand sqlcmd;
        SqlDataAdapter sqlDA;
        DataTable dt;

        public DBManager()
        {
            try
            {
                sqlcn = new SqlConnection();
                sqlcn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;
                sqlcmd = new SqlCommand(string.Empty , sqlcn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlDA = new(sqlcmd);
                dt = new DataTable();
            }
            catch
            {
            }
        }

        public int ExecuteNonQuery(string SPName ,Dictionary<string,object> Parameters)
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = SPName;

                foreach (var param in Parameters)
                    sqlcmd.Parameters.Add(new SqlParameter(param.Key,param.Value));

                if (sqlcn.State != ConnectionState.Open)
                    sqlcn.Open();

                return sqlcmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                sqlcn.Close();
            }
            return -1;
        }
        public int ExecuteNonQuery (string SPName)
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = SPName;

                if (sqlcn.State != ConnectionState.Open)
                    sqlcn.Open();

                return sqlcmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                sqlcn.Close();
            }
            return -1;
        }

        public object ExecuteScalar (string SPName) 
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = SPName;

                if (sqlcn.State != ConnectionState.Open)
                    sqlcn.Open();

                return sqlcmd.ExecuteScalar();
            }
            catch
            {

            }
            finally
            {
                sqlcn.Close();
            }
            return new();
        }
        public object ExecuteScalar(string SPName, Dictionary<string, object> Parameters) => throw new NotImplementedException();
        
        public DataTable ExecuteDataTable(string SPName)
        {
            try
            {
                dt.Clear();
                sqlcmd.Parameters.Clear();

                sqlcmd.CommandText = SPName;

                sqlDA.Fill(dt);

            }
            catch
            {

            }
            return dt;
        }
        public DataTable ExecuteDataTable(string SPName, Dictionary<string, object> Parameters) => throw new NotImplementedException();


    }
}
