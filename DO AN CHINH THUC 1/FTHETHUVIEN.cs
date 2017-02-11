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
    public partial class FTHETHUVIEN : Form
    {
        bool edit = true;
        public FTHETHUVIEN()
        {
            InitializeComponent();
        }

        private void FTHANHVIEN_Load(object sender, EventArgs e)
        { 
            loadmasv();
            loadtv();
            viewtv.ReadOnly = true;
            grb1.Enabled = false;
        }
        void cleartxt()
        {
            txtmasv.Text = "";
        }
        public void setbt(bool a)
        {
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btnxem.Enabled = a;
            btnluu.Enabled = btnhuy.Enabled = !a;
        }
        public CSDLDataContext db = new CSDLDataContext();
        void loadtv()
        {
            viewtv.DataSource = from u in db.THETHUVIENs
                                from u1 in db.SINHVIENs
                                where u.MASV==u1.MASV
                                select new { u.MATV,u.MASV,u.NGAYCAPTHE,u.NGAYHETHAN};
        }   

        private void btnthem_Click(object sender, EventArgs e)
        {
            var mapm = db.THETHUVIENs.OrderByDescending(p => p.MATV).Select(p => p.MATV).First();
            long n = long.Parse(mapm.ToString());
            n++;
            txtmaTV.Text = n.ToString();
            grb1.Enabled = true;
            viewtv.ReadOnly = true;//ko read only đc ???
            txtmasv.Enabled = txtmaTV.Enabled =dtpnc.Enabled = dtpnhh.Enabled = true;
            txtmasv.Focus();
            setbt(false);
            cleartxt();
            edit = false;
            dtpnc.Enabled = false;
        }
        public void loadmasv()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            string strConnection = "Data Source=.\\ANHKHOA;Initial Catalog=QLTHUVIENCHINHTHUC;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string sql = "Select SINHVIEN.MASV from SINHVIEN ";
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader reader;
            reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto2.Add(reader["MASV"].ToString());
                }
            }
            txtmasv.AutoCompleteMode = AutoCompleteMode.Append;
            txtmasv.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmasv.AutoCompleteCustomSource = auto2;

            txtmasv.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmasv.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmasv.AutoCompleteCustomSource = auto2;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                THETHUVIEN add = new THETHUVIEN();
                if (txtmasv.Text == null || txtmaTV.Text == null)
                {
                    MessageBox.Show("Chưa có thông tin", "Cảnh báo");
                    txtmasv.Focus();
                }
                else
                {
                    add.MASV = txtmasv.Text;
                    var k = (from u in db.THETHUVIENs where u.MASV == txtmasv.Text select u).FirstOrDefault();
                    if (k != null)
                    {
                        MessageBox.Show("Đã đăng ký", "Cảnh báo");
                        txtmasv.Focus();
                    }
                    else
                    {
                        add.NGAYCAPTHE = dtpnc.Value;
                        if (DateTime.Parse(dtpnc.Text) > DateTime.Now)
                        {
                            MessageBox.Show("Nhập quá ngày hiện hành", "Cảnh báo");
                            dtpnc.Focus();
                        }
                        else
                        {
                            add.NGAYHETHAN = dtpnhh.Value;
                            db.THETHUVIENs.InsertOnSubmit(add);
                            db.SubmitChanges();
                            MessageBox.Show("Thêm mới thành công", "Thông báo");
                            loadtv();
                        }
                    }
                }
            }
            else
            {
                THETHUVIEN a = new THETHUVIEN();
                var s = (db.THETHUVIENs.SingleOrDefault(p => p.MATV == long.Parse(txtmaTV.Text)).ToString());
                a.NGAYCAPTHE = dtpnc.Value;
                if (DateTime.Parse(dtpnc.Text) > DateTime.Now)
                {
                    MessageBox.Show("Nhập quá ngày hiện hành", "Cảnh báo");
                    dtpnc.Focus();
                }
                a.NGAYHETHAN = dtpnhh.Value;
                db.SubmitChanges();
                loadtv();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            grb1.Enabled = false;
            setbt(true);
            edit = true;
        }

        private void gridThanhvien_Click(object sender, EventArgs e)
        {
            if (viewtv.CurrentRow != null)
            {
                txtmaTV.Text = viewtv.CurrentRow.Cells[0].Value.ToString();
                txtmasv.Text = viewtv.CurrentRow.Cells[1].Value.ToString();
                dtpnc.Text = viewtv.CurrentRow.Cells[2].Value.ToString();
                dtpnhh.Text = viewtv.CurrentRow.Cells[3].Value.ToString();
                edit = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            viewtv.ReadOnly = false;
            edit = true;
            setbt(false);
            //grbtt.Enabled = true;
            txtmasv.Enabled = false;
            txtmaTV.Enabled = false;
            dtpnc.Enabled = true;
            dtpnhh.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không !!!", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var s = db.THETHUVIENs.SingleOrDefault(p => p.MATV == int.Parse (txtmaTV.Text));
                if (s != null)
                {
                    db.THETHUVIENs.DeleteOnSubmit(s);
                    db.SubmitChanges();
                    loadtv();
                    MessageBox.Show("Xóa thành công","Thông báo");
                }
                else
                    MessageBox.Show("Không tồn tại dữ liệu cần xóa");
            }
            setbt(true);
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            setbt(true);
            cleartxt();
            txtmaTV.Text = "";
            //datengaysinh.Text = dtpnc.Text = dtpnhh.Text = "";
        }
    }
}

