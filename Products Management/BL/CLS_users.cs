using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Products_Management.BL
{
    class CLS_users
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.DataAccessLayer DAL= new DAL.DataAccessLayer();
            SqlParameter[] param=new SqlParameter[2];

            param[0] = new SqlParameter("@ID",SqlDbType.VarChar,50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_LOGIN",param);
            DAL.close();
            return dt;
        
        
        }

        //دالةعرض البيانات ف داتا جريد فيو
        public DataTable getall_user()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("user_select", null);
            DAL.close();
            return dt;
        }

        //دالة ادخال بييانات المستخدمين
        public void add_user(string name, string psw, string type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@psw", SqlDbType.VarChar, 50);
            param[1].Value = psw;

            param[2] = new SqlParameter("@usertype", SqlDbType.VarChar, 50);
            param[2].Value = type;


            DAL.excutedcomand("user_insert", param);
            DAL.close();
        }

        //دالة الحذف
        public void delete_user(string username)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = username;

            DAL.excutedcomand("user_delet", param);
            DAL.close();
        }
    }
}
