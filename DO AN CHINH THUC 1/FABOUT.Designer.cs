namespace DO_AN_CHINH_THUC_1
{
    partial class FABOUT
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
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.chitietphieumuonTableAdapter1 = new DO_AN_CHINH_THUC_1.QLTHUVIENCHINHTHUCDataSet1TableAdapters.CHITIETPHIEUMUONTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = "";
            this.memoEdit1.Location = new System.Drawing.Point(120, 92);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(298, 226);
            this.memoEdit1.TabIndex = 0;
            this.memoEdit1.EditValueChanged += new System.EventHandler(this.memoEdit1_EditValueChanged);
            // 
            // chitietphieumuonTableAdapter1
            // 
            this.chitietphieumuonTableAdapter1.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(120, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(298, 74);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "  Phần mềm quản lý thư viện\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DO_AN_CHINH_THUC_1.Properties.Resources.f58e92ca554f4a44b13d6842bd389b2f;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl2.Location = new System.Drawing.Point(130, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(180, 152);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sinh viên thực hiện : \r\n- Nguyễn Lê Anh Khoa\r\n- Đặng Võ Hồng Đăng \r\n- Nguyễn Phú " +
    "Lộc \r\n- Nguyễn Thanh Long \r\n\r\n Giảng Viên hướng dẫn : \r\n- Nguyễn Trường Hải ";
            // 
            // FABOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoEdit1);
            this.Name = "FABOUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN PHẦN MỀM";
            this.Load += new System.EventHandler(this.FABOUT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private QLTHUVIENCHINHTHUCDataSet1TableAdapters.CHITIETPHIEUMUONTableAdapter chitietphieumuonTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}