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
    public partial class Control_Customer : UserControl
    {
        BL.CLS_Customer customer = new BL.CLS_Customer();
        public int ID ,positon; 
        public Control_Customer()
        {
            InitializeComponent();
            txt_fname.Focus();
            this.dgcustomer.DataSource = customer.getallcustomer();
            dgcustomer.Columns[0].Visible = false;
            dgcustomer.Columns[5].Visible = false;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("هذا العميل غير موجود");
                return;
            }
            if (MessageBox.Show("هل تريد حذف هذا العميل؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                customer.delete_customer(ID);
                this.dgcustomer.DataSource = customer.getallcustomer();
            }
        }

        private void dgcustomer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                picture_customer.Image = null;
                ID = Convert.ToInt32(dgcustomer.CurrentRow.Cells[0].Value.ToString());
                txt_fname.Text = dgcustomer.CurrentRow.Cells[1].Value.ToString();
                txt_lname.Text = dgcustomer.CurrentRow.Cells[2].Value.ToString();
                txt_phone.Text = dgcustomer.CurrentRow.Cells[3].Value.ToString();
                txt_email.Text = dgcustomer.CurrentRow.Cells[4].Value.ToString();
                byte[] img = (byte[])dgcustomer.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                picture_customer.Image = Image.FromStream(ms);
                
                lblposition.Text = Convert.ToString(ID);
            }
            catch { return; }
            
        }

        private void btn_image_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture_customer.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] picture;
                if (picture_customer.Image == null)
                {
                    if (MessageBox.Show("هل تريد اضافة هذا العميل؟", "عملية الاضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        picture = new byte[0];
                        customer.add_customer(txt_fname.Text, txt_lname.Text, txt_phone.Text, txt_email.Text, picture, "with_notimage");
                    }
                }
                else
                {
                    if (MessageBox.Show("هل تريد اضافة هذا العميل؟", "عملية الاضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        MemoryStream ms = new MemoryStream();
                        picture_customer.Image.Save(ms, picture_customer.Image.RawFormat);
                        picture = ms.ToArray();
                        customer.add_customer(txt_fname.Text, txt_lname.Text, txt_phone.Text, txt_email.Text, picture, "with_image");
                    }
                }
                
            }
            catch { return; }

            this.dgcustomer.DataSource = customer.getallcustomer();
            

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    MessageBox.Show("هذا العميل غير موجود");
                    return;
                }
                byte[] picture;
                if (picture_customer.Image == null)
                {
                    if (MessageBox.Show("هل تريد تعديل هذا العميل؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        picture = new byte[0];
                        customer.edit_customer(txt_fname.Text, txt_lname.Text, txt_phone.Text, txt_email.Text, picture, "with_notimage", ID);
                    }
                }
                else
                {
                    if (MessageBox.Show("هل تريد تعديل هذا العميل؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        MemoryStream ms = new MemoryStream();
                        picture_customer.Image.Save(ms, picture_customer.Image.RawFormat);
                        picture = ms.ToArray();
                        customer.edit_customer(txt_fname.Text, txt_lname.Text, txt_phone.Text, txt_email.Text, picture, "with_image", ID);
                    }
                }
                
            }
            catch { return; }
            this.dgcustomer.DataSource = customer.getallcustomer();
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txt_email.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_phone.Clear();
            picture_customer.Image = null;
            txt_fname.Focus();
        }

        private void txt_fname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_lname.Focus();
            }
        }

        private void txt_lname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_email.Focus();
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_phone.Focus();
            }
        }

        private void txt_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnadd.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picture_customer.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgcustomer.DataSource = customer.search(txtsearch.Text);
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        //حدث التنقل بين العملاء
        void navigate(int index)
        {
            
             try
             {
                DataTable dat = customer.getallcustomer();
                picture_customer.Image = null;
                //DataRowCollection drc = dt.Rows;
                byte[] img;
                MemoryStream ms;
                if (dat.Rows[index][5] != DBNull.Value)
                {
                    img = (byte[])dat.Rows[index][5];
                    ms = new MemoryStream(img);
                    picture_customer.Image = Image.FromStream(ms);
                }
                ID = Convert.ToInt32(dat.Rows[index][0]);
                txt_fname.Text = dat.Rows[index][1].ToString();
                txt_lname.Text = dat.Rows[index][2].ToString();
                txt_phone.Text = dat.Rows[index][3].ToString();
                txt_email.Text = dat.Rows[index][4].ToString();
                img = (byte[])dat.Rows[index][5];
                ms = new MemoryStream(img);
                picture_customer.Image = Image.FromStream(ms);
              
                string x = Convert.ToString(ID);
                //string y= Convert.ToString( customer.getallcustomer().Rows.Count - 1);
                lblposition.Text = x;
             }
             catch { return; }           
        }


        private void btnlast_Click(object sender, EventArgs e)
        {
            navigate(0);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            positon = customer.getallcustomer().Rows.Count - 1;
            navigate(positon);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (positon == 0)
            {
                MessageBox.Show("هذا هو اول عميل ");
                return;
            }
            positon -= 1;
            navigate(positon);
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (positon == customer.getallcustomer().Rows.Count - 1)
            {
                MessageBox.Show("هذا هو اخر عميل ");
                return;
            }
            positon += 1;
            navigate(positon);
        }
    }
}
