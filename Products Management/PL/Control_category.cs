using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Products_Management.PL
{
    public partial class Control_category : UserControl
    {
        BL.CLS_Category category = new BL.CLS_Category();
        public int id = new int(); 
        public Control_category()
        {
            InitializeComponent();
            this.dglist.DataSource = category.getallcategory();
        }

        private void dglist_DoubleClick(object sender, EventArgs e)
        {
            this.txtidcat.Text = dglist.CurrentRow.Cells[0].Value.ToString();
            this.txtdescat.Text = dglist.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtdescat.Clear();
            DataTable dat = category.getallcategory();
            id = dat.Rows.Count+1;
            txtidcat.Text = id.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                id = (dglist.RowCount - 1) + 1;
                if (MessageBox.Show("هل تريد اضافة هذا الصنف؟", "عملية الاضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    category.add_category(id, txtdescat.Text);
                    txtidcat.Clear();
                    txtdescat.Clear();
                    this.dglist.DataSource = category.getallcategory();
                }
            }
            catch { return; }


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تعديل هذا الصنف؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                category.edit_category(Convert.ToInt32(txtidcat.Text), txtdescat.Text);
                txtidcat.Clear();
                txtdescat.Clear();
                this.dglist.DataSource = category.getallcategory();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try{
                
                if (MessageBox.Show("هل تريد حذف هذا الصنف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                  
                        category.delete_category(Convert.ToInt32(txtidcat.Text));
                        txtidcat.Clear();
                        txtdescat.Clear();
                        this.dglist.DataSource = category.getallcategory();
                    }
                
               }
            
            catch { return; }
        }

        private void txtidcat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}