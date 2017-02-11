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
    public partial class FTHELOAI : Form
    {
        public FTHELOAI()
        {
            InitializeComponent();
        }
        public CSDLDataContext db = new CSDLDataContext();
        private void FTHELOAI_Load(object sender, EventArgs e)
        {
            txtmatl.Enabled = txtten.Enabled = false;
            setbt(true);
            loadtl();
        }
        void loadtl()
        {
            viewtl.DataSource = from u in db.THELOAIs select u;
        }
        void setbt(bool a)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = a;
            btnHuy.Enabled = btnLuu.Enabled = !a;
        }
        void cleartxt()
        {
            txtmatl.Text = txtten.Text = "";
        }
        bool edit = true;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setbt(false);
            txtmatl.Focus();
            edit = false;
            cleartxt();
            txtten.Enabled=txtmatl.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            edit = true;
            setbt(false);
            txtmatl.Enabled = false;
            txtten.Focus();
            txtten.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không !!!", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var s = db.THELOAIs.SingleOrDefault(p => p.MATL == txtmatl.Text);
                if (s != null)
                {
                    db.THELOAIs.DeleteOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    loadtl();
                }
                else
                    MessageBox.Show("Không tồn tại dữ liệu cần xóa","Thông báo");
            }
            setbt(true);
            cleartxt();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                THELOAI tl = new THELOAI();
                if (txtmatl.Text == null || txtten.Text == null)
                {
                    MessageBox.Show("Không được để trống thông tin", "Thông báo");
                    txtmatl.Focus();
                }
                else
                {
                    tl.MATL = txtmatl.Text;
                    var k = (from u in db.THELOAIs where u.MATL == txtmatl.Text select u).FirstOrDefault();
                    if (k != null)
                    {
                        MessageBox.Show("Mã thể loại đã tồn tại", "Thông báo");
                        txtmatl.Focus();
                    }
                    else
                    {

                        tl.TENTL = txtten.Text;
                        db.THELOAIs.InsertOnSubmit(tl);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mới thành công", "Thông báo");
                        loadtl();
                    }
                }
            }
            else
            {
                var t = db.THELOAIs.SingleOrDefault(p => p.MATL == txtmatl.Text);
                t.TENTL = txtten.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                loadtl();
                setbt(true);
                edit = true;
                cleartxt();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setbt(true);
            cleartxt();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewtl_Click(object sender, EventArgs e)
        {
            txtmatl.Text = viewtl.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = viewtl.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
