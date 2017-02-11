using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_CHINH_THUC_1
{
    public partial class FDANGKY : Form
    {
        public FDANGKY()
        {
            InitializeComponent();
        }
        CSDLDataContext db = new CSDLDataContext();
        private void FDANGKY_Load(object sender, EventArgs e)
        {
            setbt(true);
            loaddata();
            loadtt();
        }
        void loadtt()
        {
            VIEWDK.DataSource = from u in db.LOGINs
                                from u1 in db.SINHVIENs
                                where u.MASV == u1.MASV
                                select new { u.MASV, u.PASS, u.QUYEN };
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            txtuser.Focus();
            clear();
            setbt(false);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            LOGIN LG = new LOGIN();
            if (txtuser.Text == "" || txtmk.Text == "" || cbquyen.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin", "Thông báo");
                txtuser.Focus();
            }
            else
            {
                LG.MASV = txtuser.Text;
                var k = (from u in db.LOGINs where u.MASV == txtuser.Text select u).FirstOrDefault();
                if (k != null)
                {
                    MessageBox.Show("Đã đăng ký", "Cảnh báo");
                    txtuser.Focus();
                }
                else
                {

                    LG.PASS = txtmk.Text;
                    LG.QUYEN = cbquyen.Text;
                    if (cbquyen.Text == "admin")
                    {
                        MessageBox.Show("Sinh viên chỉ có thể là user");
                        cbquyen.Focus();
                    }
                    else
                    {
                        db.LOGINs.InsertOnSubmit(LG);
                        db.SubmitChanges();
                        MessageBox.Show("Tạo tài khoản đăng nhập thành công", "Thông báo");
                        loadtt();
                    }
                }
            }
            clear();
            setbt(true);
        }
        void clear()
        {
            txtmk.Text = txtuser.Text = cbquyen.Text = "";
        }
        void setbt(bool a)
        {
            btntao.Enabled = btnxoa.Enabled = a;
            btnhuy.Enabled = btnluu.Enabled = !a;
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtuser.Text = txtmk.Text = "";
            btnhuy.Enabled = btnluu.Enabled =btntao.Enabled=btnxoa.Enabled= true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không !!!", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var s = db.LOGINs.SingleOrDefault(p => p.MASV == txtuser.Text);
                if (s != null)
                {
                    db.LOGINs.DeleteOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    loadtt();
                    clear();
                }
                else
                    MessageBox.Show("Không tồn tại dữ liệu cần xóa");
            }
        }
        public void loaddata()
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
            txtuser.AutoCompleteMode = AutoCompleteMode.Append;
            txtuser.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtuser.AutoCompleteCustomSource = auto2;

            txtuser.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtuser.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtuser.AutoCompleteCustomSource = auto2;
        }
        private void VIEWDK_Click(object sender, EventArgs e)
        {

            if (VIEWDK.CurrentRow != null)
            {
                txtuser.Text = VIEWDK.CurrentRow.Cells[0].Value.ToString();
                txtmk.Text = VIEWDK.CurrentRow.Cells[1].Value.ToString();
                cbquyen.Text = VIEWDK.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
