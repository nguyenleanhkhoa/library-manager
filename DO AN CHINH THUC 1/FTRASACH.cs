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
    public partial class FTRASACH : Form
    {
        public FTRASACH()
        {
            InitializeComponent();
        }   
        CSDLDataContext db = new CSDLDataContext();
        public void loadthongtin()
        {
            gridtrasach.DataSource = from u in db.PHIEUMUONs
                                     from i in db.CHITIETPHIEUMUONs
                                     from S in db.SACHes
                                     orderby i.MAPM descending
                                     where S.MASACH == i.MASACH
                                     where u.MAPM == i.MAPM
                                     select new {i.MAPM,u.MATV,S.TENSACH,i.MASACH,u.NGAYMUON,i.NGAYTRA,i.HANTRA,i.TRANGTHAI };
        }
        private void FTRASACH_Load(object sender, EventArgs e)
        {
            grb1.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            btndatra.Enabled = true;
            btnthoat.Enabled = true;
            loadma();
            loadthongtin();
        }
        public void loadma()
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
            txtmaphieumuon.AutoCompleteMode = AutoCompleteMode.Append;
            txtmaphieumuon.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmaphieumuon.AutoCompleteCustomSource = auto2;

            txtmaphieumuon.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmaphieumuon.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtmaphieumuon.AutoCompleteCustomSource = auto2;
        }
        private void gridtrasach_Click(object sender, EventArgs e)
        {
            if (gridtrasach.CurrentRow != null)
            {
                txtmaphieumuon.Text = gridtrasach.CurrentRow.Cells[0].Value.ToString();
                txtmathethuvien.Text = gridtrasach.CurrentRow.Cells[1].Value.ToString();
                txttensach.Text = gridtrasach.CurrentRow.Cells[2].Value.ToString();
                txtmasach.Text = gridtrasach.CurrentRow.Cells[3].Value.ToString();
                datengaymuon.Text = gridtrasach.CurrentRow.Cells[4].Value.ToString();
                datehantra.Text = gridtrasach.CurrentRow.Cells[6].Value.ToString();
                cbtrangthai.Text = gridtrasach.CurrentRow.Cells[7].Value.ToString();
                if ((gridtrasach.CurrentRow.Cells[5].Value) == null)
                {
                    datengaytra.Enabled = false;
                    datengaytra.Text ="1/1/1975";
                }
                else
                {
                    datengaytra.Enabled = true;
                    datengaytra.Text = gridtrasach.CurrentRow.Cells[5].Value.ToString();
                }
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
           
            var s = (from u in db.CHITIETPHIEUMUONs
                     where u.MASACH == txtmasach.Text
                     select u);
           try
            {
                foreach (CHITIETPHIEUMUON u in s)
                {
                  
                    u.TRANGTHAI = cbtrangthai.Text;
                    if (gridtrasach.CurrentRow.Cells[5].Value == null)
                    {
                        var day = DateTime.Now;
                        u.NGAYTRA = DateTime.Parse(day.ToShortDateString());
                    }
                    else
                    {
                        u.NGAYTRA = DateTime.Parse(datengaytra.Text);
                    }
                    btnluu.Enabled = false;
                    btndatra.Enabled = true;
                    btnthoat.Enabled = true;
                    db.SubmitChanges();
                    MessageBox.Show("Đã lưu", "thông báo");
                    loadthongtin();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }           
        }
        private void btndatra_Click(object sender, EventArgs e)
        {
            try
            {
                gridtrasach.Enabled = true;
                grb1.Enabled = true;
                txtmaphieumuon.Focus();
                btnhuy.Enabled = true;
                btndatra.Enabled = false;
                btnluu.Enabled = true;
                datengaytra.Value = DateTime.Now;
                MessageBox.Show("Nhập mã phiếu mượn", "Thông báo");
            }
            catch (Exception)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            btnhuy.Enabled = false;
            btndatra.Enabled = true;
            btnluu.Enabled = false;
            txtmaphieumuon.Text = txtmasach.Text = txtmathethuvien.Text = txttensach.Text = cbtrangthai.Text="";
            MessageBox.Show("Đã hủy", "Thông báo");
            grb1.Enabled = false;
        }

        private void txtmaphieumuon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtmaphieumuon.Text != "")
                {


                    gridtrasach.DataSource = from u in db.PHIEUMUONs
                                             from i in db.CHITIETPHIEUMUONs
                                             from S in db.SACHes
                                             orderby i.MAPM descending
                                             where S.MASACH == i.MASACH
                                             where u.MAPM == i.MAPM
                                             where i.MAPM == long.Parse(txtmaphieumuon.Text)
                                             select new { i.MAPM, u.MATV, S.TENSACH, i.MASACH, u.NGAYMUON, i.NGAYTRA, i.HANTRA, i.TRANGTHAI };
                }
                else
                {
                    loadthongtin();
                }
            }
            catch (Exception)
            {

            }
          
        }
    }
}
