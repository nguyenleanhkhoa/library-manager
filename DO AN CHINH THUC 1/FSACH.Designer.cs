namespace DO_AN_CHINH_THUC_1
{
    partial class FSACH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSACH));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbmatl = new System.Windows.Forms.ComboBox();
            this.cbtacgia = new System.Windows.Forms.ComboBox();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.txtnamxb = new DevExpress.XtraEditors.TextEdit();
            this.txtnhaxb = new DevExpress.XtraEditors.TextEdit();
            this.grbtt = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.laout2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnxem = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.viewcapnhatsach = new System.Windows.Forms.DataGridView();
            this.qLTHUVIENDataSet = new DO_AN_CHINH_THUC_1.QLTHUVIENDataSet();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new DO_AN_CHINH_THUC_1.QLTHUVIENDataSetTableAdapters.SACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnamxb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnhaxb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laout2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewcapnhatsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbmatl);
            this.layoutControl1.Controls.Add(this.cbtacgia);
            this.layoutControl1.Controls.Add(this.txtten);
            this.layoutControl1.Controls.Add(this.txtma);
            this.layoutControl1.Controls.Add(this.txtnamxb);
            this.layoutControl1.Controls.Add(this.txtnhaxb);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(272, 142, 250, 350);
            this.layoutControl1.Root = this.grbtt;
            this.layoutControl1.Size = new System.Drawing.Size(724, 97);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbmatl
            // 
            this.cbmatl.FormattingEnabled = true;
            this.cbmatl.Location = new System.Drawing.Point(435, 12);
            this.cbmatl.Name = "cbmatl";
            this.cbmatl.Size = new System.Drawing.Size(277, 21);
            this.cbmatl.TabIndex = 4;
            this.cbmatl.SelectedIndexChanged += new System.EventHandler(this.cbmatl_SelectedIndexChanged);
            // 
            // cbtacgia
            // 
            this.cbtacgia.FormattingEnabled = true;
            this.cbtacgia.Location = new System.Drawing.Point(82, 61);
            this.cbtacgia.Name = "cbtacgia";
            this.cbtacgia.Size = new System.Drawing.Size(279, 21);
            this.cbtacgia.TabIndex = 3;
            this.cbtacgia.SelectedIndexChanged += new System.EventHandler(this.cbtacgia_SelectedIndexChanged);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(82, 12);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(279, 20);
            this.txtten.StyleController = this.layoutControl1;
            this.txtten.TabIndex = 1;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(82, 36);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(279, 20);
            this.txtma.StyleController = this.layoutControl1;
            this.txtma.TabIndex = 2;
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(435, 37);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(277, 20);
            this.txtnamxb.StyleController = this.layoutControl1;
            this.txtnamxb.TabIndex = 5;
            // 
            // txtnhaxb
            // 
            this.txtnhaxb.Location = new System.Drawing.Point(435, 61);
            this.txtnhaxb.Name = "txtnhaxb";
            this.txtnhaxb.Size = new System.Drawing.Size(277, 20);
            this.txtnhaxb.StyleController = this.layoutControl1;
            this.txtnhaxb.TabIndex = 6;
            // 
            // grbtt
            // 
            this.grbtt.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.grbtt.GroupBordersVisible = false;
            this.grbtt.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.laout2,
            this.layoutControlItem4});
            this.grbtt.Location = new System.Drawing.Point(0, 0);
            this.grbtt.Name = "Root";
            this.grbtt.Size = new System.Drawing.Size(724, 97);
            this.grbtt.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtten;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem1.Text = "Tên sách";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtnamxb;
            this.layoutControlItem3.CustomizationFormText = "Tên sách";
            this.layoutControlItem3.Location = new System.Drawing.Point(353, 25);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem3.Text = "Năm xuất bản";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtma;
            this.layoutControlItem2.CustomizationFormText = "Tên sách";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(353, 25);
            this.layoutControlItem2.Text = "Mã sách";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtnhaxb;
            this.layoutControlItem5.CustomizationFormText = "Tên sách";
            this.layoutControlItem5.Location = new System.Drawing.Point(353, 49);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(351, 28);
            this.layoutControlItem5.Text = "Nhà xuất bản";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(67, 13);
            // 
            // laout2
            // 
            this.laout2.Control = this.cbtacgia;
            this.laout2.Location = new System.Drawing.Point(0, 49);
            this.laout2.Name = "laout2";
            this.laout2.Size = new System.Drawing.Size(353, 28);
            this.laout2.Text = "Mã tác giả";
            this.laout2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbmatl;
            this.layoutControlItem4.Location = new System.Drawing.Point(353, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(351, 25);
            this.layoutControlItem4.Text = "Mã thể loại";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 13);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnhuy);
            this.groupControl1.Controls.Add(this.btnxoa);
            this.groupControl1.Controls.Add(this.btnluu);
            this.groupControl1.Controls.Add(this.btnsua);
            this.groupControl1.Controls.Add(this.btnxem);
            this.groupControl1.Controls.Add(this.btnthem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 97);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(724, 61);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Chức năng";
            // 
            // btnhuy
            // 
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(337, 22);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 33);
            this.btnhuy.TabIndex = 3;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(174, 23);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 33);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(93, 23);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 33);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(255, 22);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 33);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxem
            // 
            this.btnxem.Image = ((System.Drawing.Image)(resources.GetObject("btnxem.Image")));
            this.btnxem.Location = new System.Drawing.Point(418, 22);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 33);
            this.btnxem.TabIndex = 1;
            this.btnxem.Text = "Xem";
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(12, 23);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 33);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm ";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // viewcapnhatsach
            // 
            this.viewcapnhatsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewcapnhatsach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.viewcapnhatsach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewcapnhatsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewcapnhatsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewcapnhatsach.GridColor = System.Drawing.SystemColors.ControlLight;
            this.viewcapnhatsach.Location = new System.Drawing.Point(0, 158);
            this.viewcapnhatsach.Name = "viewcapnhatsach";
            this.viewcapnhatsach.Size = new System.Drawing.Size(724, 293);
            this.viewcapnhatsach.TabIndex = 9;
            this.viewcapnhatsach.Click += new System.EventHandler(this.viewcapnhatsach_Click);
            // 
            // qLTHUVIENDataSet
            // 
            this.qLTHUVIENDataSet.DataSetName = "QLTHUVIENDataSet";
            this.qLTHUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qLTHUVIENDataSet;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // FSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(724, 451);
            this.Controls.Add(this.viewcapnhatsach);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FSACH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN SÁCH ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FSACH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnamxb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnhaxb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laout2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewcapnhatsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraLayout.LayoutControlGroup grbtt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtnamxb;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtnhaxb;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnxem;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.DataGridView viewcapnhatsach;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private System.Windows.Forms.ComboBox cbtacgia;
        private DevExpress.XtraLayout.LayoutControlItem laout2;
        private System.Windows.Forms.ComboBox cbmatl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private QLTHUVIENDataSet qLTHUVIENDataSet;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLTHUVIENDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
    }
}