namespace DO_AN_CHINH_THUC_1
{
    partial class FDANGNHAP1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDANGNHAP1));
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.txtmk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CBmatkhau = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btndangnhap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(161, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(215, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(161, 77);
            this.txtmk.Name = "txtmk";
            this.txtmk.Properties.UseSystemPasswordChar = true;
            this.txtmk.Size = new System.Drawing.Size(215, 20);
            this.txtmk.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(163, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(163, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // CBmatkhau
            // 
            this.CBmatkhau.AutoSize = true;
            this.CBmatkhau.Location = new System.Drawing.Point(164, 103);
            this.CBmatkhau.Name = "CBmatkhau";
            this.CBmatkhau.Size = new System.Drawing.Size(109, 17);
            this.CBmatkhau.TabIndex = 6;
            this.CBmatkhau.Text = "Hiển thị mật khẩu";
            this.CBmatkhau.UseVisualStyleBackColor = true;
            this.CBmatkhau.CheckedChanged += new System.EventHandler(this.CBmatkhau_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DO_AN_CHINH_THUC_1.Properties.Resources.Account_and_Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btthoat
            // 
            this.btthoat.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.Image")));
            this.btthoat.Location = new System.Drawing.Point(279, 126);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(97, 38);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.Image")));
            this.btndangnhap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btndangnhap.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btndangnhap.Location = new System.Drawing.Point(163, 126);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(110, 38);
            this.btndangnhap.TabIndex = 4;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click_1);
          //  this.btndangnhap.Enter += new System.EventHandler(this.btndangnhap_Enter);
      //      this.btndangnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btndangnhap_KeyPress);
            // 
            // FDANGNHAP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 178);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CBmatkhau);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDANGNHAP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
    //        this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FDANGNHAP1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.TextEdit txtmk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btndangnhap;
        private DevExpress.XtraEditors.SimpleButton btthoat;
        private System.Windows.Forms.CheckBox CBmatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

