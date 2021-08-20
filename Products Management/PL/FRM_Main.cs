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
    public partial class FRM_Main : Form
    {
        private static FRM_Main frm;


        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;     
        }

        public static FRM_Main getmainform
        {
            get 
            {
                if (frm == null)
                {
                    frm = new FRM_Main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public void ShowControl(Control con)
        {
            con.Dock = DockStyle.Fill;
            panelcover.Controls.Clear();
            con.BringToFront();
            con.Focus();
            panelcover.Controls.Add(con);

        }


        public FRM_Main()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.panelbtn.Visible = false;
            this.panel2.Visible = false;
            this.panelcover.Visible = false;


        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج من البرنامج ؟", "تسجيل الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Control_Cover cover = new Control_Cover();
                ShowControl(cover);
                this.panelbtn.Visible = false;
                this.panel2.Visible = false;
                this.panelcover.Visible = false;            
            }

        }

        private void btnbuckup_Click(object sender, EventArgs e)
        {
            FRM_Login frm = new FRM_Login();
            frm.ShowDialog();
        }

        private void btnproductmanegement_Click(object sender, EventArgs e)
        {
            PL.Control_Product manprd = new Control_Product();
            ShowControl(manprd);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Control_Cover cover = new Control_Cover();
            ShowControl(cover);
        }

        private void btncategories_Click(object sender, EventArgs e)
        {
            Control_category ctegory = new Control_category();
            ShowControl(ctegory);
        }

        private void btnclients_Click(object sender, EventArgs e)
        {
            Control_Customer customer = new Control_Customer();
            ShowControl(customer);
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            Control_User user = new Control_User();
            ShowControl(user);
        }
    }
}
