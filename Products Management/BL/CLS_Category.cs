using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.BL
{
    class CLS_Category
    {
        //دالةعرض البيانات ف داتا جريد فيو
        public DataTable getallcategory()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("categoy_select", null);
            DAL.close();
            return dt;
        }
        //دالةعرض كودالصنف
        public DataTable getcat_id()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("cat_id", null);
            DAL.close();
            return dt;
        }
        //دالة اضافة صنف
        public void add_category(int id_cat, string des_cat)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@des", SqlDbType.VarChar, 25);
            param[1].Value = des_cat;

            d.excutedcomand("category_insert", param);
            d.close();
        }
        //دالة تعديل صنف
        public void edit_category(int id_cat, string des_cat)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@des", SqlDbType.VarChar, 25);
            param[1].Value = des_cat;

            d.excutedcomand("cat_update", param);
            d.close();
        }
        //دالة الحذف
        public void delete_category(int id)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            d.excutedcomand("cat_delete", param);
            d.close();
        }
    }
}
