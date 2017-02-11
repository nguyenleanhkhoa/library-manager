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
    public partial class FCHITIETPHIEUMUON : Form
    {
        CSDLDataContext db = new CSDLDataContext();
        public FCHITIETPHIEUMUON()
        {
            InitializeComponent();
        }
        public void loadmaphieu()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            string strConnection = "Data Source=.\\ANHKHOA;Initial Catalog=QLTHUVIENCHINHTHUC;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string sql = "Select PHIEUMUON.MAPM from PHIEUMUON ";
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
                    auto2.Add(reader["MAPM"].ToString());
                }
            }
            txtmapm.AutoCompleteMode = AutoCompleteMode.Append;
            txtmapm.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmapm.AutoCompleteCustomSource = auto2;

            txtmapm.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmapm.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmapm.AutoCompleteCustomSource = auto2;
        }
        void loadtensach()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            string strConnection = "Data Source=.\\ANHKHOA;Initial Catalog=QLTHUVIENCHINHTHUC;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string sql = "Select SACH.MASACH from SACH ";
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
                    auto2.Add(reader["MASACH"].ToString());
                }
            }
            txtmasach.AutoCompleteMode = AutoCompleteMode.Append;
            txtmasach.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmasach.AutoCompleteCustomSource = auto2;

            txtmasach.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmasach.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmasach.AutoCompleteCustomSource = auto2;
        }
        ActionType action = ActionType.No;
        enum ActionType
        {
            Them,
            Huy,
            Luu,
            Xoa,
            No
        }
        void Button(ActionType action)
        {
            switch (action)
            {
                case ActionType.Them:
                   
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;
                    btnthoat.Enabled = true;
                    break;
                case ActionType.Luu:
                   
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;
                    btnthoat.Enabled = true;
                    break;
                case ActionType.Huy:
                    Button(ActionType.No);
                    break;
                default:
                  
                    btnluu.Enabled = false;
                    btnhuy.Enabled = false;
                    btnthoat.Enabled = true;
                    break;
            }
        }
        void clearText()
        {
            txtmasach.Text = cbtrangthai.Text = "";
        }
        void loaddatagrid()
        {
            gridchitietphieumuon.DataSource = from s in db.SACHes
                                              from c in db.CHITIETPHIEUMUONs
                                              orderby c.MAPM descending
                                              where s.MASACH == c.MASACH
                                              select new { c.MAPM,c.MASACH,s.TENSACH,c.HANTRA,c.NGAYTRA,c.TRANGTHAI };
        }
        private void FCHITIETPHIEUMUON_Load(object sender, EventArgs e)
        {
            txtsoluong.Enabled = false;
            var soluong = db.PHIEUMUONs.OrderByDescending(p => p.MAPM).Select(p => p.SLMUON).First();
            txtsoluong.Text = soluong.ToString();
            var mapm = db.PHIEUMUONs.OrderByDescending(p => p.MAPM).Select(p => p.MAPM).First();
            txtmapm.Text = mapm.ToString();
            loadmaphieu();
            loadtensach();
            loaddatagrid();
        }
        int i = 0;
        private void btnluu_Click(object sender, EventArgs e)
        {
            int s = int.Parse(txtsoluong.Text);
            CHITIETPHIEUMUON ctpm = new CHITIETPHIEUMUON();
            ctpm.MAPM = int.Parse(txtmapm.Text);
            ctpm.MASACH = txtmasach.Text;
            var k = (from u in db.SACHes where u.MASACH == txtmasach.SelectedText.ToString() select u).FirstOrDefault();
            if (k == null)
            {
                MessageBox.Show("Mã sách không có", "Thông báo");
                txtmasach.Focus();
            }
            else
            {
                ctpm.TRANGTHAI = cbtrangthai.Text;
                if (cbtrangthai.Text == "")
                {
                    MessageBox.Show("Trạng thái không được để trống", "Thông báo");
                    cbtrangthai.Focus();
                }
                else
                {
                    ctpm.HANTRA = DateTime.Parse(dateht.Text);
                    db.CHITIETPHIEUMUONs.InsertOnSubmit(ctpm);
                    db.SubmitChanges();
                    MessageBox.Show("Lưu thành công");
                    i = i + 1;
                    if (i == s)
                    {
                        MessageBox.Show("Đã đủ số sách mượn", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Còn 1 lượt mượn sách", "Thông báo");
                        txtmasach.Focus();
                        txtmasach.Text = "";
                    }
                    loaddatagrid();
                }
            }
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
