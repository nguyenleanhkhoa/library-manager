namespace DO_AN_CHINH_THUC_1
{
    partial class FTRASACH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTRASACH));
            this.gridtrasach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btndatra = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.txtmathethuvien = new System.Windows.Forms.TextBox();
            this.txtmaphieumuon = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.datehantra = new System.Windows.Forms.DateTimePicker();
            this.datengaytra = new System.Windows.Forms.DateTimePicker();
            this.datengaymuon = new System.Windows.Forms.DateTimePicker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridtrasach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridtrasach
            // 
            this.gridtrasach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridtrasach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridtrasach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridtrasach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtrasach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7});
            this.gridtrasach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridtrasach.Location = new System.Drawing.Point(0, 169);
            this.gridtrasach.Name = "gridtrasach";
            this.gridtrasach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridtrasach.Size = new System.Drawing.Size(824, 312);
            this.gridtrasach.TabIndex = 10;
            this.gridtrasach.Click += new System.EventHandler(this.gridtrasach_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPM";
            this.Column1.HeaderText = "Mã phiếu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MATV";
            this.Column2.HeaderText = "Mã thẻ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENSACH";
            this.Column3.HeaderText = "Tên sách";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MASACH";
            this.Column4.HeaderText = "Mã Sách";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYMUON";
            this.Column5.HeaderText = "Ngày mượn";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NGAYTRA";
            this.Column6.HeaderText = "Ngày trả";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "HANTRA";
            this.Column8.HeaderText = "Hạn trả";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TRANGTHAI";
            this.Column7.HeaderText = "Trạng thái";
            this.Column7.Name = "Column7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btndatra);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 59);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnhuy
            // 
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(175, 20);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 30);
            this.btnhuy.TabIndex = 2;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btndatra
            // 
            this.btndatra.Image = ((System.Drawing.Image)(resources.GetObject("btndatra.Image")));
            this.btndatra.Location = new System.Drawing.Point(12, 19);
            this.btndatra.Name = "btndatra";
            this.btndatra.Size = new System.Drawing.Size(75, 31);
            this.btndatra.TabIndex = 1;
            this.btndatra.Text = "Sửa";
            this.btndatra.Click += new System.EventHandler(this.btndatra_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(737, 19);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 31);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(93, 19);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 31);
            this.btnluu.TabIndex = 0;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.txttensach);
            this.grb1.Controls.Add(this.txtmasach);
            this.grb1.Controls.Add(this.txtmathethuvien);
            this.grb1.Controls.Add(this.txtmaphieumuon);
            this.grb1.Controls.Add(this.labelControl7);
            this.grb1.Controls.Add(this.cbtrangthai);
            this.grb1.Controls.Add(this.labelControl6);
            this.grb1.Controls.Add(this.labelControl2);
            this.grb1.Controls.Add(this.datehantra);
            this.grb1.Controls.Add(this.datengaytra);
            this.grb1.Controls.Add(this.datengaymuon);
            this.grb1.Controls.Add(this.labelControl8);
            this.grb1.Controls.Add(this.labelControl5);
            this.grb1.Controls.Add(this.labelControl3);
            this.grb1.Controls.Add(this.labelControl4);
            this.grb1.Controls.Add(this.labelControl1);
            this.grb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb1.Location = new System.Drawing.Point(0, 0);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(824, 110);
            this.grb1.TabIndex = 8;
            this.grb1.TabStop = false;
            this.grb1.Text = "Chi tiết phiếu trả sách";
            // 
            // txttensach
            // 
            this.txttensach.Enabled = false;
            this.txttensach.Location = new System.Drawing.Point(567, 52);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(193, 20);
            this.txttensach.TabIndex = 15;
            // 
            // txtmasach
            // 
            this.txtmasach.Enabled = false;
            this.txtmasach.Location = new System.Drawing.Point(567, 23);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(193, 20);
            this.txtmasach.TabIndex = 14;
            // 
            // txtmathethuvien
            // 
            this.txtmathethuvien.Enabled = false;
            this.txtmathethuvien.Location = new System.Drawing.Point(95, 52);
            this.txtmathethuvien.Name = "txtmathethuvien";
            this.txtmathethuvien.Size = new System.Drawing.Size(184, 20);
            this.txtmathethuvien.TabIndex = 13;
            // 
            // txtmaphieumuon
            // 
            this.txtmaphieumuon.Location = new System.Drawing.Point(94, 23);
            this.txtmaphieumuon.Name = "txtmaphieumuon";
            this.txtmaphieumuon.Size = new System.Drawing.Size(185, 20);
            this.txtmaphieumuon.TabIndex = 12;
            this.txtmaphieumuon.TextChanged += new System.EventHandler(this.txtmaphieumuon_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Trạng thái ";
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Đã trả"});
            this.cbtrangthai.Location = new System.Drawing.Point(95, 78);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(121, 21);
            this.cbtrangthai.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(508, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Tên sách";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(508, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mã sách";
            // 
            // datehantra
            // 
            this.datehantra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datehantra.Location = new System.Drawing.Point(346, 78);
            this.datehantra.Name = "datehantra";
            this.datehantra.Size = new System.Drawing.Size(149, 20);
            this.datehantra.TabIndex = 5;
            // 
            // datengaytra
            // 
            this.datengaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaytra.Location = new System.Drawing.Point(346, 52);
            this.datengaytra.Name = "datengaytra";
            this.datengaytra.Size = new System.Drawing.Size(149, 20);
            this.datengaytra.TabIndex = 5;
            // 
            // datengaymuon
            // 
            this.datengaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaymuon.Location = new System.Drawing.Point(346, 23);
            this.datengaymuon.Name = "datengaymuon";
            this.datengaymuon.Size = new System.Drawing.Size(149, 20);
            this.datengaymuon.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(285, 81);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Hạn trả";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(285, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Ngày trả";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(285, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ngày mượn";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mã thẻ thư viện";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu mượn";
            // 
            // FTRASACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 481);
            this.Controls.Add(this.gridtrasach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grb1);
            this.Name = "FTRASACH";
            this.Text = "TRẢ SÁCH ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FTRASACH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtrasach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridtrasach;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.DateTimePicker datengaytra;
        private System.Windows.Forms.DateTimePicker datengaymuon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txtmathethuvien;
        private System.Windows.Forms.TextBox txtmaphieumuon;
        private DevExpress.XtraEditors.SimpleButton btndatra;
        private System.Windows.Forms.DateTimePicker datehantra;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
    }
}