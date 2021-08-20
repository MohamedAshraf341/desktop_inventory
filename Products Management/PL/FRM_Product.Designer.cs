namespace Products_Management.PL
{
    partial class FRM_Product
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Product));
            this.label6 = new System.Windows.Forms.Label();
            this.combcat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtref = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1055, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "صورة المنتج";
            // 
            // combcat
            // 
            this.combcat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.combcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combcat.ForeColor = System.Drawing.Color.Black;
            this.combcat.FormattingEnabled = true;
            this.combcat.Location = new System.Drawing.Point(200, 90);
            this.combcat.Name = "combcat";
            this.combcat.Size = new System.Drawing.Size(253, 27);
            this.combcat.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "الكمية المخزنه";
            // 
            // txtref
            // 
            this.txtref.ForeColor = System.Drawing.Color.Black;
            this.txtref.Location = new System.Drawing.Point(200, 144);
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(253, 26);
            this.txtref.TabIndex = 51;
            this.txtref.Validated += new System.EventHandler(this.txtref_Validated);
            // 
            // txtdes
            // 
            this.txtdes.ForeColor = System.Drawing.Color.Black;
            this.txtdes.Location = new System.Drawing.Point(200, 194);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdes.Size = new System.Drawing.Size(253, 54);
            this.txtdes.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "صنف المنتج";
            // 
            // txtquant
            // 
            this.txtquant.ForeColor = System.Drawing.Color.Black;
            this.txtquant.Location = new System.Drawing.Point(200, 275);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(253, 26);
            this.txtquant.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "سعر المنتج";
            // 
            // txtprice
            // 
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.Location = new System.Drawing.Point(200, 328);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(253, 26);
            this.txtprice.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "كود المنتج";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Products_Management.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(595, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "وصف المنتج";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(543, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 94);
            this.button1.TabIndex = 56;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.ForeColor = System.Drawing.Color.Black;
            this.btnok.Image = ((System.Drawing.Image)(resources.GetObject("btnok.Image")));
            this.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnok.Location = new System.Drawing.Point(319, 402);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(134, 60);
            this.btnok.TabIndex = 57;
            this.btnok.Text = "اضافة";
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.Location = new System.Drawing.Point(170, 402);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(134, 60);
            this.btnnew.TabIndex = 58;
            this.btnnew.Text = "جديد";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(704, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 44);
            this.button2.TabIndex = 59;
            this.button2.Text = "حذف الصورة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(963, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtref);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combcat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة منتج جديد";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox combcat;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtref;
        public System.Windows.Forms.TextBox txtdes;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtquant;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnok;
        public System.Windows.Forms.Button btnnew;
        public System.Windows.Forms.Button button2;


    }
}