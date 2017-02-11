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

    public partial class FDANGNHAP1 : Form
    {
        public FDANGNHAP1()
        {
            InitializeComponent();
        }
        CSDLDataContext db = new CSDLDataContext();
        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            var kt_id = (from u in db.LOGINs where u.MASV == txtid.Text select u.MASV).SingleOrDefault();
            //tìm id từ bảng loginadmin xuất ra id cần tìm được nhập từ txtid
            var kt_pass = (from u in db.LOGINs where u.PASS == txtmk.Text select u.PASS).SingleOrDefault();
            //lấy pass từ database theo id nhập trên txt id
            var kt_quyen = (from u in db.LOGINs where u.PASS == txtmk.Text && u.MASV == txtid.Text select u.QUYEN).SingleOrDefault();
            if (kt_id != null) // kiểm tra id vừa tìm có đúng với id admin đúng với id trong nhập hay ko
            {//nếu đúng tài khoàn thì kiểm tra pass
                if (kt_pass != null) //kiểm tra pass vừa tìm đc
                {
                    if (String.Compare(kt_quyen, "admin", true) == 0)
                    {
                        TRANGCHU.q = true; //biến phân quyền từ form main
                        MessageBox.Show("Đăng nhập thành công với quyền admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        TRANGCHU n = new TRANGCHU();
                        n.Show();
                    }
                    else //sai pass
                    {
                        TRANGCHU.q = false;
                        MessageBox.Show("Chào Mừng user", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon
                                .Information);
                        this.Hide();
                        TRANGCHU n = new TRANGCHU();
                        n.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu", "Thông báo");
                    txtmk.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không đúng", "Thông báo");
                txtid.Focus();
            }
        }

        private void FDANGNHAP1_Load(object sender, EventArgs e)
        {
            txtid.Focus();
            
        }
      private void CBmatkhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CBmatkhau.Checked == true)
            {
                txtmk.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtmk.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("BẠN CÓ MUỐN THOÁT", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}


