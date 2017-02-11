namespace DO_AN_CHINH_THUC_1
{
    partial class FTHETHUVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTHETHUVIEN));
            this.btnxem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.viewtv = new System.Windows.Forms.DataGridView();
            this.MATV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHETHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.dtpnc = new System.Windows.Forms.DateTimePicker();
            this.dtpnhh = new System.Windows.Forms.DateTimePicker();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txtmaTV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewtv)).BeginInit();
            this.grb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnxem
            // 
            this.btnxem.Image = ((System.Drawing.Image)(resources.GetObject("btnxem.Image")));
            this.btnxem.Location = new System.Drawing.Point(336, 19);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 33);
            this.btnxem.TabIndex = 2;
            this.btnxem.Text = "Xem";
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(255, 19);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 33);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(174, 19);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 33);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Chỉnh sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(93, 19);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 33);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(12, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 33);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(418, 19);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 33);
            this.btnhuy.TabIndex = 7;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // viewtv
            // 
            this.viewtv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewtv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.viewtv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewtv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATV,
            this.MASSV,
            this.NGAYCAP,
            this.NGAYHETHAN});
            this.viewtv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewtv.Location = new System.Drawing.Point(3, 16);
            this.viewtv.Name = "viewtv";
            this.viewtv.Size = new System.Drawing.Size(720, 273);
            this.viewtv.TabIndex = 9;
            this.viewtv.Click += new System.EventHandler(this.gridThanhvien_Click);
            // 
            // MATV
            // 
            this.MATV.DataPropertyName = "MATV";
            this.MATV.HeaderText = "Mã thư viện";
            this.MATV.Name = "MATV";
            // 
            // MASSV
            // 
            this.MASSV.DataPropertyName = "MASV";
            this.MASSV.HeaderText = "Mã sinh viên";
            this.MASSV.Name = "MASSV";
            // 
            // NGAYCAP
            // 
            this.NGAYCAP.DataPropertyName = "NGAYCAPTHE";
            this.NGAYCAP.HeaderText = "Ngày cấp thẻ";
            this.NGAYCAP.Name = "NGAYCAP";
            // 
            // NGAYHETHAN
            // 
            this.NGAYHETHAN.DataPropertyName = "NGAYHETHAN";
            this.NGAYHETHAN.HeaderText = "Ngày hết hạn";
            this.NGAYHETHAN.Name = "NGAYHETHAN";
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.dtpnc);
            this.grb1.Controls.Add(this.dtpnhh);
            this.grb1.Controls.Add(this.txtmasv);
            this.grb1.Controls.Add(this.txtmaTV);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb1.Location = new System.Drawing.Point(0, 0);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(726, 66);
            this.grb1.TabIndex = 10;
            this.grb1.TabStop = false;
            this.grb1.Text = "Thông tin thẻ thành viên";
            // 
            // dtpnc
            // 
            this.dtpnc.Enabled = false;
            this.dtpnc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnc.Location = new System.Drawing.Point(435, 10);
            this.dtpnc.Name = "dtpnc";
            this.dtpnc.Size = new System.Drawing.Size(200, 20);
            this.dtpnc.TabIndex = 200000;
            // 
            // dtpnhh
            // 
            this.dtpnhh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnhh.Location = new System.Drawing.Point(435, 37);
            this.dtpnhh.Name = "dtpnhh";
            this.dtpnhh.Size = new System.Drawing.Size(200, 20);
            this.dtpnhh.TabIndex = 2;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(99, 37);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(211, 20);
            this.txtmasv.TabIndex = 1;
            // 
            // txtmaTV
            // 
            this.txtmaTV.Enabled = false;
            this.txtmaTV.Location = new System.Drawing.Point(99, 13);
            this.txtmaTV.Name = "txtmaTV";
            this.txtmaTV.ReadOnly = true;
            this.txtmaTV.Size = new System.Drawing.Size(211, 20);
            this.txtmaTV.TabIndex = 1000;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày hết hạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày cấp thẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thẻ thư viện";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnxem);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 63);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.viewtv);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 292);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết thẻ thành viên";
            // 
            // FTHETHUVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 421);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grb1);
            this.MinimizeBox = false;
            this.Name = "FTHETHUVIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THẺ THƯ VIỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FTHANHVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewtv)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnxem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.DataGridView viewtv;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHETHAN;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.DateTimePicker dtpnc;
        private System.Windows.Forms.DateTimePicker dtpnhh;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txtmaTV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}