using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.BL
{
    class CLS_Customer
    {
        //دالة البحث
        public DataTable search(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@txtserch", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = DAL.SelectData("customer_search", param);
            DAL.close();
            return dt;
        }
        //دالةعرض البيانات ف داتا جريد فيو
        public DataTable getallcustomer()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("customer_select", null);
            DAL.close();
            return dt;
        }
        //دالة عرض الصورة
        public DataTable get_img_customer(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = DAL.SelectData("customer_image", param);
            DAL.close();
            return dt;
        }

        //دالة اضافة عميل
        public void add_customer(string f_name, string l_name, string phone, string e_maile, byte[] img_customer,string x)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@f_name", SqlDbType.VarChar, 25);
            param[0].Value=f_name;

            param[1] = new SqlParameter("@l_name", SqlDbType.VarChar, 25);
            param[1].Value = l_name;

            param[2] = new SqlParameter("@telephone", SqlDbType.NChar, 15);
            param[2].Value = phone;

            param[3] = new SqlParameter("@e_maile", SqlDbType.VarChar, 25);
            param[3].Value = e_maile;

            param[4] = new SqlParameter("@img_customer", SqlDbType.Image);
            param[4].Value = img_customer;

            param[5] = new SqlParameter("@x", SqlDbType.VarChar, 25);
            param[5].Value = x;
            d.excutedcomand("customer_insert", param);
            d.close();
            
        }
        //دالة تعديل عميل
        public void edit_customer(string f_name, string l_name, string phone, string e_maile, byte[] img_customer, string x,int id)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@f_name", SqlDbType.VarChar, 25);
            param[0].Value = f_name;

            param[1] = new SqlParameter("@l_name", SqlDbType.VarChar, 25);
            param[1].Value = l_name;

            param[2] = new SqlParameter("@telephone", SqlDbType.NChar, 15);
            param[2].Value = phone;

            param[3] = new SqlParameter("@e_maile", SqlDbType.VarChar, 25);
            param[3].Value = e_maile;

            param[4] = new SqlParameter("@img_customer", SqlDbType.Image);
            param[4].Value = img_customer;

            param[5] = new SqlParameter("@x", SqlDbType.VarChar, 25);
            param[5].Value = x;

            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Value = id;
            d.excutedcomand("customer_update", param);
            d.close();

        }
        //دالة الحذف
        public void delete_customer(int id)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            d.excutedcomand("customer_delet", param);
            d.close();
        }
    }
}
