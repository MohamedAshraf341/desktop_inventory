using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Products_Management.PL
{
    public partial class FRM_Product : Form
    {
        public string state = "add";
        Control_Product prdmanage = new Control_Product();
        BL.CLS_Product prd = new BL.CLS_Product();

        public FRM_Product()
        {
            InitializeComponent();
            //تعبئة الكومبوبوكس
            combcat.DataSource = prd.getallcat();
            combcat.DisplayMember = "DESCRIPTION_CAT";
            combcat.ValueMember = "ID_CAT";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
//زر الاضاة والتعديل
        private void button3_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                try
                {
                    //عشان نسجل البيانات المدخله الي قاعدة البيانات   
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteimage = ms.ToArray();
                    prd.add_product(txtref.Text, txtdes.Text, Convert.ToInt32(txtquant.Text), txtprice.Text, byteimage, Convert.ToInt32(combcat.SelectedValue));
                    MessageBox.Show("تمت الاضافه بنجاح ", "عملية اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { return; }
            }
            else
            {
                try
                {
                    //عشان تعدل البيانات المدخله الي قاعدة البيانات   
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteimage = ms.ToArray();
                    prd.edit_prduct(txtref.Text, txtdes.Text, Convert.ToInt32(txtquant.Text), txtprice.Text, byteimage, Convert.ToInt32(combcat.SelectedValue));
                    MessageBox.Show("تمت التعديل بنجاح ", "عملية تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { return; }
            }
            

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtdes.Clear();
            txtprice.Clear();
            txtquant.Clear();
            txtref.Clear();
            txtref.Focus();
        }
        //من خلال الحدث فاليديتيد الموجود في التكست بوكس الخاص ب اي دي 
        //اذا كان اي دي موجود مسبقا يظهر الرسساله
        private void txtref_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = prd.verifyid(txtref.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الكود موجود مسبقا ", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtref.Focus();
                    txtref.SelectionStart = 0;
                    txtref.SelectionLength = txtref.TextLength;
                }
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }


    }
}
