namespace DO_AN_CHINH_THUC_1
{
    partial class FQUANLYSACH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQUANLYSACH));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.viewcapnhatsach = new System.Windows.Forms.DataGridView();
            this.search = new DevExpress.XtraEditors.SearchControl();
            this.cbloc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewcapnhatsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbloc);
            this.groupControl1.Controls.Add(this.search);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(723, 61);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Chức năng";
            // 
            // viewcapnhatsach
            // 
            this.viewcapnhatsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewcapnhatsach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.viewcapnhatsach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewcapnhatsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewcapnhatsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewcapnhatsach.GridColor = System.Drawing.SystemColors.ControlLight;
            this.viewcapnhatsach.Location = new System.Drawing.Point(0, 61);
            this.viewcapnhatsach.Name = "viewcapnhatsach";
            this.viewcapnhatsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewcapnhatsach.Size = new System.Drawing.Size(723, 391);
            this.viewcapnhatsach.TabIndex = 10;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(140, 34);
            this.search.Name = "search";
            this.search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.search.Size = new System.Drawing.Size(200, 20);
            this.search.TabIndex = 0;
            this.search.SelectedIndexChanged += new System.EventHandler(this.search_SelectedIndexChanged);
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // cbloc
            // 
            this.cbloc.FormattingEnabled = true;
            this.cbloc.Items.AddRange(new object[] {
            "Mã Sách",
            "Tên Sách"});
            this.cbloc.Location = new System.Drawing.Point(13, 34);
            this.cbloc.Name = "cbloc";
            this.cbloc.Size = new System.Drawing.Size(121, 21);
            this.cbloc.TabIndex = 1;
            // 
            // FQUANLYSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 452);
            this.Controls.Add(this.viewcapnhatsach);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FQUANLYSACH";
            this.Text = "QUẢN LÝ SÁCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FQUANLYSACH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewcapnhatsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView viewcapnhatsach;
        private DevExpress.XtraEditors.SearchControl search;
        private System.Windows.Forms.ComboBox cbloc;
    }
}