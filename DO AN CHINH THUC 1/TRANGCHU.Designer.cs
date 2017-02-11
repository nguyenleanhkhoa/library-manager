namespace DO_AN_CHINH_THUC_1
{
    partial class TRANGCHU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRANGCHU));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnquanlysach = new DevExpress.XtraBars.BarButtonItem();
            this.btnquanlydocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btccs = new DevExpress.XtraBars.BarButtonItem();
            this.btcnls = new DevExpress.XtraBars.BarButtonItem();
            this.btcntg = new DevExpress.XtraBars.BarButtonItem();
            this.btnmuonsach = new DevExpress.XtraBars.BarButtonItem();
            this.btntrasach = new DevExpress.XtraBars.BarButtonItem();
            this.bttk = new DevExpress.XtraBars.BarButtonItem();
            this.btncndg = new DevExpress.XtraBars.BarButtonItem();
            this.taotk = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.chucnang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowDrop = true;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnquanlysach,
            this.btnquanlydocgia,
            this.btccs,
            this.btcnls,
            this.btcntg,
            this.btnmuonsach,
            this.btntrasach,
            this.bttk,
            this.btncndg,
            this.taotk,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.chucnang,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(909, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnquanlysach
            // 
            this.btnquanlysach.Caption = "Quản lý sách";
            this.btnquanlysach.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources._51181;
            this.btnquanlysach.Id = 1;
            this.btnquanlysach.LargeWidth = 75;
            this.btnquanlysach.Name = "btnquanlysach";
            this.btnquanlysach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnquanlysach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnquanlydocgia
            // 
            this.btnquanlydocgia.Caption = "Quản lý đọc giả";
            this.btnquanlydocgia.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.info_5121;
            this.btnquanlydocgia.Id = 2;
            this.btnquanlydocgia.LargeWidth = 75;
            this.btnquanlydocgia.Name = "btnquanlydocgia";
            this.btnquanlydocgia.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnquanlydocgia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnquanlydocgia_ItemClick);
            // 
            // btccs
            // 
            this.btccs.Caption = "Cập nhật sách ";
            this.btccs.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.return_book11;
            this.btccs.Id = 3;
            this.btccs.LargeWidth = 75;
            this.btccs.Name = "btccs";
            this.btccs.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btccs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhatsach_ItemClick);
            // 
            // btcnls
            // 
            this.btcnls.Caption = "Cập nhật loại sách";
            this.btcnls.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.logo_icon1;
            this.btcnls.Id = 4;
            this.btcnls.LargeWidth = 75;
            this.btcnls.Name = "btcnls";
            this.btcnls.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btcnls.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhatloaisach_ItemClick);
            // 
            // btcntg
            // 
            this.btcntg.Caption = "Cập nhật tác giả";
            this.btcntg.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.Inkwell_icon___Noun_Project_25121;
            this.btcntg.Id = 5;
            this.btcntg.LargeWidth = 75;
            this.btcntg.Name = "btcntg";
            this.btcntg.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btcntg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhattacgia_ItemClick);
            // 
            // btnmuonsach
            // 
            this.btnmuonsach.Caption = "Mượn Sách";
            this.btnmuonsach.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.borrow_512;
            this.btnmuonsach.Id = 6;
            this.btnmuonsach.LargeWidth = 75;
            this.btnmuonsach.Name = "btnmuonsach";
            this.btnmuonsach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnmuonsach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmuonsach_ItemClick);
            // 
            // btntrasach
            // 
            this.btntrasach.Caption = "Trả sách";
            this.btntrasach.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.return_book12;
            this.btntrasach.Id = 7;
            this.btntrasach.LargeWidth = 75;
            this.btntrasach.Name = "btntrasach";
            this.btntrasach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btntrasach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btntrasach_ItemClick);
            // 
            // bttk
            // 
            this.bttk.Caption = "Thông kê ";
            this.bttk.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.rising_trend_chart_icon_70391;
            this.bttk.Id = 8;
            this.bttk.LargeWidth = 75;
            this.bttk.Name = "bttk";
            this.bttk.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bttk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bttk_ItemClick);
            // 
            // btncndg
            // 
            this.btncndg.Caption = "Cập nhật độc giả";
            this.btncndg.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources._1480883559_User;
            this.btncndg.Id = 10;
            this.btncndg.LargeWidth = 75;
            this.btncndg.Name = "btncndg";
            this.btncndg.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btncndg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // taotk
            // 
            this.taotk.Caption = "Tạo tài khoản đăng nhập";
            this.taotk.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.signup;
            this.taotk.Id = 11;
            this.taotk.Name = "taotk";
            this.taotk.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.taotk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_2);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng xuất";
            this.barButtonItem1.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.logout_512;
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_3);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Cập nhật thẻ thành viên";
            this.barButtonItem2.Glyph = global::DO_AN_CHINH_THUC_1.Properties.Resources.library_icon;
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnquanlysach);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnquanlydocgia);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // chucnang
            // 
            this.chucnang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.chucnang.Name = "chucnang";
            this.chucnang.Text = "Chức năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btccs);
            this.ribbonPageGroup2.ItemLinks.Add(this.btcnls);
            this.ribbonPageGroup2.ItemLinks.Add(this.btcntg);
            this.ribbonPageGroup2.ItemLinks.Add(this.bttk);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Mượn - Trả sách";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnmuonsach);
            this.ribbonPageGroup3.ItemLinks.Add(this.btntrasach);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Hỗ trợ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.taotk);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 651);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(909, 31);
            // 
            // TRANGCHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 682);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TRANGCHU";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "THƯ VIỆN SÁCH ";
            this.Load += new System.EventHandler(this.TRANGCHU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnquanlysach;
        private DevExpress.XtraBars.Ribbon.RibbonPage chucnang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem btnquanlydocgia;
        private DevExpress.XtraBars.BarButtonItem btccs;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btcnls;
        private DevExpress.XtraBars.BarButtonItem btcntg;
        private DevExpress.XtraBars.BarButtonItem btnmuonsach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btntrasach;
        private DevExpress.XtraBars.BarButtonItem bttk;
        private DevExpress.XtraBars.BarButtonItem btncndg;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem taotk;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}