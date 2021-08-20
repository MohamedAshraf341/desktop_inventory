using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.BL
{
    class CLS_Product
    {
        //دالة تعبيئة الكومبوبوكس بالمنتجات
        public DataTable getallcat()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();           
            DataTable dt = new DataTable();
            dt = DAL.SelectData("select_cat", null);
            DAL.close();
            return dt;
        }
        //دالة التحقق من عدم وجود معرف المنتوج مسبقا
        public DataTable verifyid(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = DAL.SelectData("verify_productid", param);
            DAL.close();
            return dt;
        }
        //دالةعرض البيانات ف داتا جريد فيو
        public DataTable getallprd()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("selectproduct", null);
            DAL.close();
            return dt;
        }
        //دالة البحث
        public DataTable search(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = DAL.SelectData("searchproduct", param);
            DAL.close();
            return dt;
        }
        //دالة عرض الصورة
        public DataTable get_img_prd(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 30);
            param[0].Value = id;
            dt = DAL.SelectData("get_img_prd", param);
            DAL.close();
            return dt;
        }
        //دالة اضافة منتج
        public void add_product(string id_prd,string lbl_prd,int qte_in_stock,string price,byte[] img_prd,int id_cat)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param=new SqlParameter[6];

            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[0].Value = id_prd;

            param[1] = new SqlParameter("@label_product", SqlDbType.VarChar, 30);
            param[1].Value = lbl_prd;

            param[2] = new SqlParameter("@qte_in_stock", SqlDbType.Int);
            param[2].Value = qte_in_stock;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@image_product", SqlDbType.Image);
            param[4].Value = img_prd;

            param[5] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[5].Value = id_cat;

            d.excutedcomand("insert_product", param);
            d.close();
        }
        //دالة تعديل منتج
        public void edit_prduct(string id_prd, string lbl_prd, int qte_in_stock, string price, byte[] img_prd, int id_cat)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[0].Value = id_prd;

            param[1] = new SqlParameter("@label_product", SqlDbType.VarChar, 30);
            param[1].Value = lbl_prd;

            param[2] = new SqlParameter("@qte_in_stock", SqlDbType.Int);
            param[2].Value = qte_in_stock;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@image_product", SqlDbType.Image);
            param[4].Value = img_prd;

            param[5] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[5].Value = id_cat;

            d.excutedcomand("edit_prd", param);
            d.close();
        }
        //دالة الحذف
        public void delete_product(string id_prd)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 30);
            param[0].Value = id_prd;

            d.excutedcomand("delete_prd", param);
            d.close();
        }

    }
}
