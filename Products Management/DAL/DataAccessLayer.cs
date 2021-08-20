using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.DAL
{
     class DataAccessLayer
    {
        SqlConnection SqlConnection;

        //this is constructor inisilaize connection object
        public DataAccessLayer()
        {
            SqlConnection = new SqlConnection(@"server=DESKTOP-H4F6IAP\SQLEXPRESS;  DataBase=Product_db; integrated security=true");
        }

        //method to open connection
        public void open()
        {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }

        }

        //method to close connection
        public void close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }

        }

        //method to read data from database 
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //method to insert, update and delete data 
        public void excutedcomand(string store_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = store_procedure;
            sqlcmd.Connection = SqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();

        }


    }
}
