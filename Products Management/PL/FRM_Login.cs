using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_Login : Form
    {
        BL.CLS_users log = new BL.CLS_users();
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtid.Text, txtpwd.Text);
            
            

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "Admin")
                {
                    FRM_Main.getmainform.panelbtn.Visible = true;
                    Control_Cover cover = new Control_Cover();
                    FRM_Main.getmainform.ShowControl(cover);
                    FRM_Main.getmainform.panelcover.Visible = true;
                    FRM_Main.getmainform.btnsetting.Visible = true;
                    FRM_Main.getmainform.btnuser.Visible = true;
                    FRM_Main.getmainform.panel2.Visible = true;
                    this.Close();
                }
                else if (dt.Rows[0][2].ToString() == "Normal_User")
                {
                    FRM_Main.getmainform.panelbtn.Visible = true;
                    Control_Cover cover = new Control_Cover();
                    FRM_Main.getmainform.ShowControl(cover);
                    FRM_Main.getmainform.panelcover.Visible = true;
                    FRM_Main.getmainform.btnsetting.Visible = false;
                    FRM_Main.getmainform.btnuser.Visible = false;
                    FRM_Main.getmainform.panel2.Visible = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(" login failed !");

            }
        }



        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpwd.Focus();
            }
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }
    }
}
