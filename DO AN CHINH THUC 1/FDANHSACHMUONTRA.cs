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
    public partial class FDANHSACHMUONTRA : Form
    {
        public FDANHSACHMUONTRA()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            txttim.AutoCompleteMode = AutoCompleteMode.Append;
            txttim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttim.AutoCompleteCustomSource = auto2;

            txttim.AutoCompleteMode = AutoCompleteMode.Suggest;
            txttim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttim.AutoCompleteCustomSource = auto2;
        }
        private void FDANHSACHMUONTRA_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
