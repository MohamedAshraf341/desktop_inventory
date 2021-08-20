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
    public partial class Control_User : UserControl
        
    {
        BL.CLS_users users = new BL.CLS_users();
        public Control_User()
        {
            InitializeComponent();
            this.dguser.DataSource = users.getall_user();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txt_user_name.Clear();
            txt_user_psw.Clear();
        }

        private void btnadd_user_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user_psw.Text == String.Empty || txt_user_name.Text == String.Empty)
                {
                    MessageBox.Show("من فضلك ادخل البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    
                }
                else if (MessageBox.Show("هل تريد اضافة هذا المستخدم ", " عملية الاضافة ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    users.add_user(txt_user_name.Text, txt_user_psw.Text, combtype.Text);
                    
                    
                }

            }
            catch { return; }

            this.dguser.DataSource = users.getall_user();
        }

        private void btndelete_user_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user_psw.Text == String.Empty || txt_user_name.Text == String.Empty)
                {
                    MessageBox.Show("من فضلك ادخل البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else if (MessageBox.Show("هل تريد حذق هذا المستخدم ", " عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    users.delete_user(txt_user_name.Text);
                    txt_user_name.Clear();
                    txt_user_psw.Clear();

                }

            }
            catch { return; }

            this.dguser.DataSource = users.getall_user();
        }

        private void dguser_DoubleClick(object sender, EventArgs e)
        {
            txt_user_name.Text = dguser.CurrentRow.Cells[0].Value.ToString();
            txt_user_psw.Text=dguser.CurrentRow.Cells[1].Value.ToString();
            combtype.Text = dguser.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
