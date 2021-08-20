namespace Products_Management.PL
{
    partial class Control_Customer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Customer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgcustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.picture_customer = new System.Windows.Forms.PictureBox();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgcustomer);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(57, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 234);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة العملاء";
            // 
            // dgcustomer
            // 
            this.dgcustomer.AllowUserToAddRows = false;
            this.dgcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcustomer.Location = new System.Drawing.Point(20, 28);
            this.dgcustomer.MultiSelect = false;
            this.dgcustomer.Name = "dgcustomer";
            this.dgcustomer.ReadOnly = true;
            this.dgcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcustomer.Size = new System.Drawing.Size(921, 192);
            this.dgcustomer.TabIndex = 0;
            this.dgcustomer.DoubleClick += new System.EventHandler(this.dgcustomer_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 35);
            this.panel1.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(450, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "ادارة العملاء";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_image);
            this.groupBox2.Controls.Add(this.picture_customer);
            this.groupBox2.Controls.Add(this.txt_phone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_lname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblposition);
            this.groupBox2.Controls.Add(this.btnfirst);
            this.groupBox2.Controls.Add(this.btnprevious);
            this.groupBox2.Controls.Add(this.btnnext);
            this.groupBox2.Controls.Add(this.btnlast);
            this.groupBox2.Controls.Add(this.txt_fname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(57, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 239);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 189);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 89;
            this.button1.Text = "حذف الصورة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_phone.Location = new System.Drawing.Point(239, 128);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(228, 29);
            this.txt_phone.TabIndex = 86;
            this.txt_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_phone_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(501, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 85;
            this.label5.Text = "التليفون";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.ForeColor = System.Drawing.Color.Black;
            this.txt_lname.Location = new System.Drawing.Point(239, 52);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(228, 29);
            this.txt_lname.TabIndex = 84;
            this.txt_lname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_lname_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(484, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 83;
            this.label4.Text = "اسم العائلة";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.Location = new System.Drawing.Point(608, 128);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(228, 29);
            this.txt_email.TabIndex = 82;
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(844, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 81;
            this.label3.Text = "البريد الالكتروني";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.ForeColor = System.Drawing.Color.White;
            this.lblposition.Location = new System.Drawing.Point(536, 190);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(25, 32);
            this.lblposition.TabIndex = 80;
            this.lblposition.Text = "-";
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.Color.Black;
            this.txt_fname.Location = new System.Drawing.Point(608, 52);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(228, 29);
            this.txt_fname.TabIndex = 75;
            this.txt_fname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fname_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(879, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "اسم العميل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtsearch);
            this.groupBox3.Location = new System.Drawing.Point(57, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 58);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بحث عام";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.Location = new System.Drawing.Point(20, 23);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(283, 29);
            this.txtsearch.TabIndex = 76;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(309, 23);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(47, 29);
            this.button2.TabIndex = 89;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_image.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_image.ForeColor = System.Drawing.Color.White;
            this.btn_image.Image = ((System.Drawing.Image)(resources.GetObject("btn_image.Image")));
            this.btn_image.Location = new System.Drawing.Point(144, 188);
            this.btn_image.Name = "btn_image";
            this.btn_image.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_image.Size = new System.Drawing.Size(64, 44);
            this.btn_image.TabIndex = 88;
            this.btn_image.UseVisualStyleBackColor = false;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // picture_customer
            // 
            this.picture_customer.BackColor = System.Drawing.Color.White;
            this.picture_customer.Location = new System.Drawing.Point(20, 25);
            this.picture_customer.Name = "picture_customer";
            this.picture_customer.Size = new System.Drawing.Size(188, 151);
            this.picture_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_customer.TabIndex = 87;
            this.picture_customer.TabStop = false;
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnfirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfirst.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirst.ForeColor = System.Drawing.Color.White;
            this.btnfirst.Image = ((System.Drawing.Image)(resources.GetObject("btnfirst.Image")));
            this.btnfirst.Location = new System.Drawing.Point(667, 178);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnfirst.Size = new System.Drawing.Size(69, 44);
            this.btnfirst.TabIndex = 79;
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprevious.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.ForeColor = System.Drawing.Color.White;
            this.btnprevious.Image = ((System.Drawing.Image)(resources.GetObject("btnprevious.Image")));
            this.btnprevious.Location = new System.Drawing.Point(592, 178);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnprevious.Size = new System.Drawing.Size(69, 44);
            this.btnprevious.TabIndex = 78;
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnnext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnext.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Image = ((System.Drawing.Image)(resources.GetObject("btnnext.Image")));
            this.btnnext.Location = new System.Drawing.Point(429, 178);
            this.btnnext.Name = "btnnext";
            this.btnnext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnnext.Size = new System.Drawing.Size(69, 44);
            this.btnnext.TabIndex = 77;
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlast.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.ForeColor = System.Drawing.Color.White;
            this.btnlast.Image = ((System.Drawing.Image)(resources.GetObject("btnlast.Image")));
            this.btnlast.Location = new System.Drawing.Point(354, 178);
            this.btnlast.Name = "btnlast";
            this.btnlast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnlast.Size = new System.Drawing.Size(69, 44);
            this.btnlast.TabIndex = 76;
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.Location = new System.Drawing.Point(755, 314);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(132, 44);
            this.btnadd.TabIndex = 58;
            this.btnadd.Text = "اضافة ";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.Location = new System.Drawing.Point(900, 314);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(132, 44);
            this.btnnew.TabIndex = 57;
            this.btnnew.Text = "جديد";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.Location = new System.Drawing.Point(610, 315);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(132, 44);
            this.btnupdate.TabIndex = 56;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.Location = new System.Drawing.Point(465, 314);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(132, 44);
            this.btndelete.TabIndex = 55;
            this.btndelete.Text = "حذف ";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Control_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_Customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1084, 646);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.Button btnnew;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgcustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btn_image;
        public System.Windows.Forms.TextBox txt_phone;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_lname;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_email;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblposition;
        public System.Windows.Forms.Button btnfirst;
        public System.Windows.Forms.Button btnprevious;
        public System.Windows.Forms.Button btnnext;
        public System.Windows.Forms.Button btnlast;
        public System.Windows.Forms.TextBox txt_fname;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.PictureBox picture_customer;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}
