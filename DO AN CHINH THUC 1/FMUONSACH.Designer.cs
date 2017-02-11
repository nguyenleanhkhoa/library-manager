namespace DO_AN_CHINH_THUC_1
{
    partial class FMUONSACH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMUONSACH));
            this.gridviewMSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.GRPHIEUMUON = new System.Windows.Forms.GroupBox();
            this.txtmathuvien = new System.Windows.Forms.TextBox();
            this.txtmaPM = new System.Windows.Forms.TextBox();
            this.datengaymuon = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Numsoluong = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GRPHIEUMUON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewMSach
            // 
            this.gridviewMSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewMSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridviewMSach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridviewMSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewMSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6});
            this.gridviewMSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewMSach.Location = new System.Drawing.Point(0, 153);
            this.gridviewMSach.Name = "gridviewMSach";
            this.gridviewMSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewMSach.Size = new System.Drawing.Size(700, 259);
            this.gridviewMSach.TabIndex = 13;
            this.gridviewMSach.Click += new System.EventHandler(this.gridviewMSach_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPM";
            this.Column1.HeaderText = "Mã phiếu mượn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MATV";
            this.Column2.HeaderText = "Mã thư viện";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SLMUON";
            this.Column3.HeaderText = "Số lượng ";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NGAYMUON";
            this.Column6.HeaderText = "Ngày mượn";
            this.Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 53);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnhuy
            // 
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(176, 20);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 27);
            this.btnhuy.TabIndex = 0;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(613, 19);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 28);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(95, 20);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 27);
            this.btnluu.TabIndex = 0;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(14, 20);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 27);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Tạo";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // GRPHIEUMUON
            // 
            this.GRPHIEUMUON.Controls.Add(this.txtmathuvien);
            this.GRPHIEUMUON.Controls.Add(this.txtmaPM);
            this.GRPHIEUMUON.Controls.Add(this.datengaymuon);
            this.GRPHIEUMUON.Controls.Add(this.labelControl5);
            this.GRPHIEUMUON.Controls.Add(this.Numsoluong);
            this.GRPHIEUMUON.Controls.Add(this.labelControl2);
            this.GRPHIEUMUON.Controls.Add(this.labelControl4);
            this.GRPHIEUMUON.Controls.Add(this.labelControl1);
            this.GRPHIEUMUON.Dock = System.Windows.Forms.DockStyle.Top;
            this.GRPHIEUMUON.Location = new System.Drawing.Point(0, 0);
            this.GRPHIEUMUON.Name = "GRPHIEUMUON";
            this.GRPHIEUMUON.Size = new System.Drawing.Size(700, 100);
            this.GRPHIEUMUON.TabIndex = 11;
            this.GRPHIEUMUON.TabStop = false;
            // 
            // txtmathuvien
            // 
            this.txtmathuvien.Location = new System.Drawing.Point(95, 44);
            this.txtmathuvien.Name = "txtmathuvien";
            this.txtmathuvien.Size = new System.Drawing.Size(172, 20);
            this.txtmathuvien.TabIndex = 1;
            // 
            // txtmaPM
            // 
            this.txtmaPM.Location = new System.Drawing.Point(95, 18);
            this.txtmaPM.Name = "txtmaPM";
            this.txtmaPM.Size = new System.Drawing.Size(172, 20);
            this.txtmaPM.TabIndex = 13;
            // 
            // datengaymuon
            // 
            this.datengaymuon.Enabled = false;
            this.datengaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaymuon.Location = new System.Drawing.Point(423, 22);
            this.datengaymuon.Name = "datengaymuon";
            this.datengaymuon.Size = new System.Drawing.Size(174, 20);
            this.datengaymuon.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(334, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Ngày mượn :";
            // 
            // Numsoluong
            // 
            this.Numsoluong.Location = new System.Drawing.Point(95, 70);
            this.Numsoluong.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Numsoluong.Name = "Numsoluong";
            this.Numsoluong.Size = new System.Drawing.Size(85, 20);
            this.Numsoluong.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Số lượng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 47);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mã thẻ thư viện";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu mượn";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // FMUONSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 412);
            this.Controls.Add(this.gridviewMSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GRPHIEUMUON);
            this.Name = "FMUONSACH";
            this.Text = "PHIẾU MƯỢN SÁCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMUONSACH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.GRPHIEUMUON.ResumeLayout(false);
            this.GRPHIEUMUON.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewMSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.GroupBox GRPHIEUMUON;
        private System.Windows.Forms.NumericUpDown Numsoluong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private System.Windows.Forms.DateTimePicker datengaymuon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtmaPM;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.TextBox txtmathuvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}