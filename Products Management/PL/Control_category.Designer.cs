namespace Products_Management.PL
{
    partial class Control_category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_category));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dglist = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsaveall = new System.Windows.Forms.Button();
            this.btnprintall = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtidcat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglist)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(450, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "ادارة الاصناف";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dglist);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(192, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 228);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة الاصناف";
            // 
            // dglist
            // 
            this.dglist.AllowUserToAddRows = false;
            this.dglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglist.BackgroundColor = System.Drawing.Color.White;
            this.dglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglist.Location = new System.Drawing.Point(33, 28);
            this.dglist.MultiSelect = false;
            this.dglist.Name = "dglist";
            this.dglist.ReadOnly = true;
            this.dglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dglist.Size = new System.Drawing.Size(637, 192);
            this.dglist.TabIndex = 0;
            this.dglist.DoubleClick += new System.EventHandler(this.dglist_DoubleClick);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Location = new System.Drawing.Point(192, 314);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(307, 44);
            this.btnsave.TabIndex = 45;
            this.btnsave.Text = "حفظ الصنف الحالي بجميع منتجاته في ملف pdf";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.Location = new System.Drawing.Point(627, 249);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(132, 44);
            this.btnadd.TabIndex = 44;
            this.btnadd.Text = "اضافة ";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsaveall
            // 
            this.btnsaveall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsaveall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaveall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveall.ForeColor = System.Drawing.Color.White;
            this.btnsaveall.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveall.Image")));
            this.btnsaveall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsaveall.Location = new System.Drawing.Point(519, 314);
            this.btnsaveall.Name = "btnsaveall";
            this.btnsaveall.Size = new System.Drawing.Size(190, 44);
            this.btnsaveall.TabIndex = 43;
            this.btnsaveall.Text = "حفظ القائمة في ملف pdf";
            this.btnsaveall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveall.UseVisualStyleBackColor = false;
            // 
            // btnprintall
            // 
            this.btnprintall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprintall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprintall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintall.ForeColor = System.Drawing.Color.White;
            this.btnprintall.Image = ((System.Drawing.Image)(resources.GetObject("btnprintall.Image")));
            this.btnprintall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprintall.Location = new System.Drawing.Point(732, 314);
            this.btnprintall.Name = "btnprintall";
            this.btnprintall.Size = new System.Drawing.Size(174, 44);
            this.btnprintall.TabIndex = 42;
            this.btnprintall.Text = "طباعة كل الاصناف";
            this.btnprintall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprintall.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.Location = new System.Drawing.Point(192, 249);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(132, 44);
            this.btnprint.TabIndex = 41;
            this.btnprint.Text = "طباغة الصنف";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.Location = new System.Drawing.Point(772, 249);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(132, 44);
            this.btnnew.TabIndex = 40;
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
            this.btnupdate.Location = new System.Drawing.Point(482, 250);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(132, 44);
            this.btnupdate.TabIndex = 39;
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
            this.btndelete.Location = new System.Drawing.Point(337, 249);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(132, 44);
            this.btndelete.TabIndex = 38;
            this.btndelete.Text = "حذف ";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtidcat
            // 
            this.txtidcat.ForeColor = System.Drawing.Color.Black;
            this.txtidcat.Location = new System.Drawing.Point(377, 101);
            this.txtidcat.Name = "txtidcat";
            this.txtidcat.ReadOnly = true;
            this.txtidcat.Size = new System.Drawing.Size(228, 29);
            this.txtidcat.TabIndex = 47;
            this.txtidcat.TextChanged += new System.EventHandler(this.txtidcat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(623, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "كود الصنف";
            // 
            // txtdescat
            // 
            this.txtdescat.ForeColor = System.Drawing.Color.Black;
            this.txtdescat.Location = new System.Drawing.Point(377, 153);
            this.txtdescat.Name = "txtdescat";
            this.txtdescat.Size = new System.Drawing.Size(228, 29);
            this.txtdescat.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(623, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "وصف الصنف";
            // 
            // Control_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.txtdescat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidcat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsaveall);
            this.Controls.Add(this.btnprintall);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Control_category";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1084, 646);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dglist;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.Button btnsaveall;
        public System.Windows.Forms.Button btnprintall;
        public System.Windows.Forms.Button btnprint;
        public System.Windows.Forms.Button btnnew;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.TextBox txtidcat;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtdescat;
        public System.Windows.Forms.Label label2;
    }
}
