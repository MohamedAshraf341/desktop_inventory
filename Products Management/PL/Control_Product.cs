using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Products_Management.PL
{
    public partial class Control_Product : UserControl
    {
        BL.CLS_Product prd = new BL.CLS_Product();

        public Control_Product()
        {
            
            InitializeComponent();
            this.dataGridView1.DataSource = prd.getallprd();
        }

        private void txtsrchprd_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.search(txtsearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا المنتج؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.delete_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            this.dataGridView1.DataSource = prd.getallprd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Product frm = new FRM_Product();
                frm.btnnew.Visible = false;
                frm.Text = "تعديل بيانات المنتج";
                frm.btnok.Text = "تعديل";
                frm.txtref.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtdes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtquant.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtprice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.combcat.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.state = "update";
                frm.txtref.ReadOnly = true;
                byte[] img = (byte[])prd.get_img_prd(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                frm.pictureBox1.Image = Image.FromStream(ms);
                frm.ShowDialog();
                this.dataGridView1.DataSource = prd.getallprd();
            }
            catch { return; }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRM_Product frm = new FRM_Product();
            frm.ShowDialog();
            this.dataGridView1.DataSource = prd.getallprd();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_ImgProduct frm = new FRM_ImgProduct();
                byte[] img = (byte[])prd.get_img_prd(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                frm.pictureBox1.Image = Image.FromStream(ms);
                frm.ShowDialog();
                this.dataGridView1.DataSource = prd.getallprd();
            }
            catch { return; }


        }


    }
}
