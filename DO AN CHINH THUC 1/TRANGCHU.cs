using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DO_AN_CHINH_THUC_1
{
    public partial class TRANGCHU : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TRANGCHU()
        {
           
            InitializeComponent();
        }
        public static bool q;
        private Form Kiemtratontai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)// nếu form dc truyền vào đã được mở
                {
                    return f;
                }
            }
            return null;
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form fsach = this.Kiemtratontai(typeof(FQUANLYSACH));
            if (fsach != null)
            {
                fsach.Activate();
            }
            else
            {
                FQUANLYSACH fr = new FQUANLYSACH();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnquanlydocgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form fthanhvien = this.Kiemtratontai(typeof(FQUANLYTHANHVIEN));
            if (fthanhvien != null)
            {
                fthanhvien.Activate();
            }
            else
            {
                FQUANLYTHANHVIEN fr = new FQUANLYTHANHVIEN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btncapnhattacgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form ftacgia = this.Kiemtratontai(typeof(FTACGIA));
            if (ftacgia != null)
            {
                ftacgia.Activate();
            }
            else
            {
                FTACGIA fr = new FTACGIA();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnmuonsach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form fmuonsach = this.Kiemtratontai(typeof(FMUONSACH));
            if (fmuonsach != null)
            {
                fmuonsach.Activate();
            }
            else
            {
                FMUONSACH fr = new FMUONSACH();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btntrasach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form ftrasach = this.Kiemtratontai(typeof(FTRASACH));
            if (ftrasach != null)
            {
                ftrasach.Activate();
            }
            else
            {
                FTRASACH fr = new FTRASACH();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btncapnhatsach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form fsach = this.Kiemtratontai(typeof(FSACH));
            if (fsach != null)
            {
                fsach.Activate();
            }
            else
            {
                FSACH fr = new FSACH();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btncapnhatloaisach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form FTHELOAI = this.Kiemtratontai(typeof(FTHELOAI));
            if (FTHELOAI != null)
            {
                FTHELOAI.Activate();
            }
            else
            {
                FTHELOAI fr = new FTHELOAI();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void TRANGCHU_Load(object sender, EventArgs e)
        {
            FABOUT about = new FABOUT();
            about.MdiParent = this;
            about.Show();
            
            if(q==true)
            {

            }
            else
            {
                barButtonItem2.Enabled= taotk.Enabled= btccs.Enabled = btcnls.Enabled = btcntg.Enabled = bttk.Enabled = btncndg.Enabled=btnquanlydocgia.Enabled=btnmuonsach.Enabled=btntrasach.Enabled= false;
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form fthanhvien = this.Kiemtratontai(typeof(FTHETHUVIEN));
            if (fthanhvien != null)
            {
                fthanhvien.Activate();
            }
            else
            {
                FTHETHUVIEN fr = new FTHETHUVIEN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            Form fdangky = this.Kiemtratontai(typeof(FDANGKY));
            if (fdangky != null)
            {
                fdangky.Activate();
            }
            else
            {
                FDANGKY fr = new FDANGKY();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void bttk_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form fbaocao = this.Kiemtratontai(typeof(FBAOCAO));
            if (fbaocao != null)
            {
                fbaocao.Activate();
            }
            else
            {
                FBAOCAO fr = new FBAOCAO();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barButtonItem1_ItemClick_3(object sender, ItemClickEventArgs e)
        { 
            DialogResult b = MessageBox.Show("Bạn có muốn thoát không !!!", "Thông báo", MessageBoxButtons.YesNo);
            if (b == DialogResult.Yes)
            {
                this.Close();
                FDANGNHAP1 a = new FDANGNHAP1();
                a.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form fthethuvien = this.Kiemtratontai(typeof(FTHETHUVIEN));
            if (fthethuvien != null)
            {
                fthethuvien.Activate();
            }
            else
            {
                FTHETHUVIEN fr = new FTHETHUVIEN();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}