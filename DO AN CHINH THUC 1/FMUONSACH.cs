using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_CHINH_THUC_1
{
    public partial class FMUONSACH : Form
    {
        ActionType action = ActionType.No;
        enum ActionType
        {
            Them,
            Luu,
            Sua,
            Huy,
            Xoa,
            No              //default
        }
        CSDLDataContext db = new CSDLDataContext();
        void cleartext()
        {
             txtmathuvien.Text = "";
            
        }
        void setButton(ActionType action)
        {
            switch (action)
            {
                case ActionType.Them:
                    btnthem.Enabled = false;
             //       btnxoa.Enabled = false;
                    btnthoat.Enabled = true;
                    btnhuy.Enabled = true;
                    btnluu.Enabled = true;
                    break;
                case ActionType.Luu:
                    btnthem.Enabled = true;
            //        btnxoa.Enabled = true;
                    btnthoat.Enabled = false;
                    btnhuy.Enabled = false;
                    btnluu.Enabled = false;
                    break;
                case ActionType.Xoa:
             //       btnxoa.Enabled = true;
                    btnthem.Enabled = true;
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;
                    break;
                case ActionType.Huy:
                    setButton(ActionType.No);
                    break;
                default:
                    btnthem.Enabled = true;
                //    btnxoa.Enabled = false;
                    btnthoat.Enabled = true;
                    btnhuy.Enabled = false;
                    btnluu.Enabled = false;
                    break;
            }
        }

        public FMUONSACH()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmaphieumuon_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void datacollectionmatv()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            string strConnection = "Data Source=.\\ANHKHOA;Initial Catalog=QLTHUVIENCHINHTHUC;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string sql = "Select THETHUVIEN.MATV from THETHUVIEN ";
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
                    auto2.Add(reader["MATV"].ToString());
                }
            }
            txtmathuvien.AutoCompleteMode = AutoCompleteMode.Append;
            txtmathuvien.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmathuvien.AutoCompleteCustomSource = auto2;

            txtmathuvien.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmathuvien.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmathuvien.AutoCompleteCustomSource = auto2;
        }
        private void txtsachmuon_EditValueChanged(object sender, EventArgs e)
        {
           
        }
        void loadthongtin()
        {

            gridviewMSach.DataSource = (from u in db.PHIEUMUONs
                                        orderby u.MAPM descending
                                        select new { u.MAPM, u.MATV, u.SLMUON, u.NGAYMUON });

        }
        private void FMUONSACH_Load(object sender, EventArgs e)
        {
            action = ActionType.No;
            setButton(action);
            GRPHIEUMUON.Enabled = false;
            txtmaPM.ReadOnly=true;
            datacollectionmatv();
            loadthongtin();
         }
        private void btnthem_Click(object sender, EventArgs e)
        {
            gridviewMSach.ReadOnly = true;
            var mapm = db.PHIEUMUONs.OrderByDescending(p => p.MAPM).Select(p => p.MAPM).First();
            long n = long.Parse(mapm.ToString());
            n++;
            txtmaPM.Text = n.ToString();
            GRPHIEUMUON.Enabled = true;
            action = ActionType.Them;
            setButton(action);
            cleartext();
            txtmathuvien.Focus();
        }
        void DeleteNhanVien(int mapm)
        {
            var svs = db.PHIEUMUONs.Where(u => u.MAPM == mapm);
            if (svs != null)
            {
                PHIEUMUON sv = svs.First();
                db.PHIEUMUONs.DeleteOnSubmit(sv);
                db.SubmitChanges();
                   
            }
            else
                MessageBox.Show("Không tìm thấy sinh viên để xóa");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (action == ActionType.Them)
            {
                if (txtmathuvien.Text == "")
                {
                    MessageBox.Show("Mã thẻ thư viện không được để trống", "Thông báo");
                    txtmathuvien.Focus();
                }
                else
                {
                    PHIEUMUON pm = new PHIEUMUON();
                    pm.MATV = long.Parse(txtmathuvien.Text);
                    pm.NGAYMUON = DateTime.Parse(datengaymuon.Text);
                    pm.SLMUON = int.Parse(Numsoluong.Value.ToString());
                    int a = int.Parse(Numsoluong.Value.ToString());
                    if (a == 0)
                    {
                         MessageBox.Show("Số lượng mượn lớn hơn 0 bé hơn 3", "Thông báo");
                         Numsoluong.Focus();
                    }
                    else
                    {
                         db.PHIEUMUONs.InsertOnSubmit(pm);
                         db.SubmitChanges();
                         MessageBox.Show("Tạo phiếu mượn thành công", "Thông báo");
                         loadthongtin();
                         FCHITIETPHIEUMUON fr = new FCHITIETPHIEUMUON();
                         fr.ShowDialog();
                         action = ActionType.No;
                         setButton(action);
                    }
                }           
            }
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            action = ActionType.Huy;
            setButton(action);
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            action = ActionType.Sua;
            setButton(action);
        }

        private void gridviewMSach_Click(object sender, EventArgs e)
        {
            if (gridviewMSach.CurrentRow != null)
            {
                txtmaPM.Text = gridviewMSach.CurrentRow.Cells[0].Value.ToString();
                txtmathuvien.Text = gridviewMSach.CurrentRow.Cells[1].Value.ToString();
                Numsoluong.Value = int.Parse(gridviewMSach.CurrentRow.Cells[2].Value.ToString());
                datengaymuon.Text = gridviewMSach.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
