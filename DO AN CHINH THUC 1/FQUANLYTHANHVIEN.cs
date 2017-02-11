using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DO_AN_CHINH_THUC_1
{
    public partial class FQUANLYTHANHVIEN : Form
    {
        public FQUANLYTHANHVIEN()
        {
            InitializeComponent();
        }
        CSDLDataContext db=new CSDLDataContext();
        private void btntim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtten.Text))
            {
                Viewthanhvien.DataSource = db.SINHVIENs.Where(p => p.HOTEN.Equals(txtten.Text));
            }
            else if (!string.IsNullOrEmpty(txtma.Text))
            {
                Viewthanhvien.DataSource = db.SINHVIENs.Where(p => p.MASV.Equals(txtma.Text));
            }
            else if (!string.IsNullOrEmpty(txtemail.Text))
            {
                Viewthanhvien.DataSource = db.SINHVIENs.Where(p => p.EMAIL.Equals(txtemail.Text));
            }
            else if(txtten.Text=="" && txtma.Text=="" && txtemail.Text == "" )
            {
                MessageBox.Show("bạn chưa nhập dữ liệu tìm kiếm!", "thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            Viewthanhvien.DataSource = from u in db.SINHVIENs
                                       from u1 in db.THETHUVIENs
                                       where u.MASV == u1.MASV
                                       select new { u.HOTEN,u1.MATV,u.EMAIL,u.NGAYSINH,u1.NGAYCAPTHE,u1.NGAYHETHAN};
           
        }
        private void FQUANLYTHANHVIEN_Load(object sender, EventArgs e)
        {
            datengaysinh.Enabled = false;
            datengaylapthe.Enabled = false;
            datengayhethan.Enabled = false;
        }

        private void Viewthanhvien_Click(object sender, EventArgs e)
        {
            if (Viewthanhvien.CurrentRow != null)
            {
                txtten.Text = Viewthanhvien.CurrentRow.Cells[0].Value.ToString();
                txtma.Text = Viewthanhvien.CurrentRow.Cells[1].Value.ToString();
                txtemail.Text = Viewthanhvien.CurrentRow.Cells[2].Value.ToString();
                datengaysinh.Text = Viewthanhvien.CurrentRow.Cells[3].Value.ToString();
                datengaylapthe.Text = Viewthanhvien.CurrentRow.Cells[4].Value.ToString();
                datengayhethan.Text = Viewthanhvien.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
