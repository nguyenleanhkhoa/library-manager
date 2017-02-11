using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_CHINH_THUC_1
{
    public partial class FSACH : Form
    {
        bool edit = true;
        public CSDLDataContext db = new CSDLDataContext();
        public FSACH()
        {
            InitializeComponent();
            db = new CSDLDataContext();
        }
        public void setbutton(bool a)
        {
            btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = btnxem.Enabled = a;
            btnluu.Enabled = btnxem.Enabled = btnhuy.Enabled = !a;
        }
        void cleartxt()
        {
            txtma.Text = txtten.Text = txtnamxb.Text = txtnhaxb.Text = cbmatl.Text = cbtacgia.Text = "";
        }     
        public void settxtt(bool b)
        {
            txtten.Enabled = !b;
            txtnamxb.Enabled = !b;
            txtnhaxb.Enabled = !b;
            cbmatl.Enabled = !b;
            cbtacgia.Enabled = !b;

        }
        public void loadsach()
        {
            viewcapnhatsach.DataSource = from a in db.SACHes
                                    from b in db.TACGIAs
                                    from c in db.THELOAIs
                                    where a.MATG == b.MATG
                                    where a.MATL == c.MATL
                                    select new { a.MASACH, a.TENSACH, a.MATG, a.MATL, a.NAMXB, a.NHAXB };
        }


        private void FSACH_Load(object sender, EventArgs e)
        {
             loadsach();
             OnloadTheloai();
             OnloadTacgia();
             settxtt(true);
             txtma.Enabled = false;
            cleartxt();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            edit = false;
            setbutton(false);
            cleartxt();
            txtten.Focus();
            txtma.Enabled = txtten.Enabled =txtnamxb.Enabled = txtnhaxb.Enabled = cbmatl.Enabled =cbtacgia.Enabled = true;
        }
        void OnloadTheloai()// load cb thể loại
        {
            var matg = db.THELOAIs;
            if (matg != null && matg.Count() > 0)
            {
                cbmatl.DataSource = matg;
                cbmatl.DisplayMember = "MATL";
                cbmatl.ValueMember = "TENTL";
            }
        }
        void OnloadTacgia()//load cb tác giả
        {
            var matg = db.TACGIAs;
            if (matg != null && matg.Count() > 0)
            {
                cbtacgia.DataSource = matg;
                cbtacgia.DisplayMember = "MATG";
                cbtacgia.ValueMember = "TENTG";
            }
        }
        void ClearTextbox()
        {
            txtma.Text = txtten.Text = txtnamxb.Text = txtnhaxb.Text = cbmatl.Text = cbtacgia.Text = "";
        }
 
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!edit)
            {

                SACH sach = new SACH();
                if (txtma.Text == null || txtten.Text == null || txtnhaxb.Text == null || txtnamxb.Text == null)
                {
                    MessageBox.Show("Không được để trống", "Cảnh báo");
                }
                else
                {
                    sach.MASACH = txtma.Text;
                    var k = (from u in db.SACHes where u.MASACH == txtma.Text select u).FirstOrDefault();
                    if (k != null)
                    {
                        MessageBox.Show("Mã sách đã tồn tại");
                        txtma.Focus();
                    }
                    else
                    {
                        sach.TENSACH = txtten.Text;
                        sach.MATG = cbtacgia.Text;
                        sach.MATL = cbmatl.Text;
                        sach.NAMXB = txtnamxb.Text;
                        sach.NHAXB = txtnhaxb.Text;
                        db.SACHes.InsertOnSubmit(sach);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mới thành công", "Thông báo");
                        loadsach();
                        setbutton(true);
                        edit = true;
                    }
                } 
            }
            else
            {
                var s = db.SACHes.SingleOrDefault(p => p.MASACH == txtma.Text);
                s.TENSACH = txtten.Text;
                s.MATG = cbtacgia.Text;
                s.MATL = cbmatl.Text;
                s.NAMXB = txtnamxb.Text;
                s.NHAXB = txtnhaxb.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công","Thông báo");
                loadsach();
                setbutton(true);
                edit = true;
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            edit = true;
            setbutton(false);
            grbtt.Enabled = txtten.Enabled = txtnamxb.Enabled =txtnhaxb.Enabled = true;
            txtma.Enabled = cbmatl.Enabled =cbtacgia.Enabled = false;
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            setbutton(true);
            cleartxt();
            cbtacgia.Text = cbmatl.Text = "";
            txtma.Enabled = txtten.Enabled = txtnamxb.Enabled = txtnhaxb.Enabled = cbmatl.Enabled =  cbtacgia.Enabled = false;
        }

        private void viewcapnhatsach_Click(object sender, EventArgs e)
        {
            if (viewcapnhatsach.CurrentRow != null)
            {
                txtma.Text = viewcapnhatsach.CurrentRow.Cells[0].Value.ToString();
                txtten.Text = viewcapnhatsach.CurrentRow.Cells[1].Value.ToString();
                cbtacgia.Text = viewcapnhatsach.CurrentRow.Cells[2].Value.ToString();
                cbmatl.Text = viewcapnhatsach.CurrentRow.Cells[3].Value.ToString();
                txtnamxb.Text = viewcapnhatsach.CurrentRow.Cells[4].Value.ToString();
                txtnhaxb.Text = viewcapnhatsach.CurrentRow.Cells[5].Value.ToString();
                edit = true;
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không !!!", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var s = db.SACHes.SingleOrDefault(p => p.MASACH == txtma.Text);
                if (s != null)
                {
                    db.SACHes.DeleteOnSubmit(s);
                    db.SubmitChanges();
                    loadsach();
                    MessageBox.Show("Xóa thành công","Thông báo");
                }
                else
                    MessageBox.Show("Không tồn tại dữ liệu cần xóa");
            }
        }
        private void cbtacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnloadTacgia();
        }

        private void cbmatl_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnloadTheloai();
        }
    }
}

