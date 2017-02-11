namespace DO_AN_CHINH_THUC_1
{
    partial class FBAOCAO
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BAOCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCao = new DO_AN_CHINH_THUC_1.BaoCao();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BAOCAOTableAdapter = new DO_AN_CHINH_THUC_1.BaoCaoTableAdapters.BAOCAOTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAOCAOBindingSource
            // 
            this.BAOCAOBindingSource.DataMember = "BAOCAO";
            this.BAOCAOBindingSource.DataSource = this.BaoCao;
            // 
            // BaoCao
            // 
            this.BaoCao.DataSetName = "BaoCao";
            this.BaoCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đã trả",
            "Chưa trả"});
            this.cbTrangThai.Location = new System.Drawing.Point(15, 19);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(169, 21);
            this.cbTrangThai.TabIndex = 1;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(204, 17);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BaoCao";
            reportDataSource1.Value = this.BAOCAOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DO_AN_CHINH_THUC_1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(723, 306);
            this.reportViewer1.TabIndex = 3;
            // 
            // BAOCAOTableAdapter
            // 
            this.BAOCAOTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 325);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // FBAOCAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FBAOCAO";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.FBAOCAO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btnXuat;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BAOCAOBindingSource;
        private BaoCao BaoCao;
        private BaoCaoTableAdapters.BAOCAOTableAdapter BAOCAOTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}