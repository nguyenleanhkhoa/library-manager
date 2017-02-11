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
    public partial class FTACGIA : Form
    {
       
        ActionType action = ActionType.No;
        enum ActionType
        {
            Them,
            Luu,
            Sua,
            Huy,
            No              //default
        }
        CSDLDataContext QL;
        void OnlyReadOnTextBox(bool b)
        {
            txtMaTG.ReadOnly = b;
            txtTenTG.ReadOnly = b;
        }
        void OnloadTacGia()
        {
            ListViewtacgia.Items.Clear();
            QL = new CSDLDataContext();
            var tacgias = QL.TACGIAs;
            if (tacgias != null && tacgias.Count() > 0)
            {
                foreach (TACGIA t in tacgias)
                {
                    ListViewItem lsv = ListViewtacgia.Items.Add(t.MATG);
                    lsv.SubItems.Add(t.TENTG);
                }
            }
        }
        void SetButtonEnable(ActionType action)
        {
            switch (action)
            {
                case ActionType.Them:
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThoat.Enabled = false;
                    btnHuy.Enabled = true;
                    btnLuu.Enabled = true;
                    OnlyReadOnTextBox(false);
                    break;
                case ActionType.Sua:
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThoat.Enabled = false;
                    btnHuy.Enabled = true;
                    btnLuu.Enabled = true;
                    OnlyReadOnTextBox(false);
                    break;
                case ActionType.Luu:
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThoat.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    OnlyReadOnTextBox(true);
                    break;
                case ActionType.Huy:
                    SetButtonEnable(ActionType.No);
                    break;
                default:
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThoat.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    OnlyReadOnTextBox(true);
                    break;
            }
        }
        public FTACGIA()
        {
            InitializeComponent();
            QL = new CSDLDataContext();
        }
        private void FTACGIA_Load(object sender, EventArgs e)
        {
            action = ActionType.No;
            SetButtonEnable(action);
            OnloadTacGia();
            Cleartext();
        }
        TACGIA Gettextbox()
        {
            return new TACGIA
            {
                MATG = txtMaTG.Text,
                TENTG = txtTenTG.Text
            };
        }
        void Update(string matg)
        {
            var tg = QL.TACGIAs.Where(t => t.MATG == matg);
            if (tg != null)
            {
                TACGIA tgs = tg.First();
                Update(tgs);
            }
        }
        void Update(TACGIA tgs)
        {
            try
            {
                tgs.MATG = txtMaTG.Text;
                tgs.TENTG = txtTenTG.Text;
                QL.SubmitChanges();
                OnloadTacGia();
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật");
            }
        }
        void Cleartext()
        {
            txtMaTG.Text = txtTenTG.Text = "";
            txtMaTG.Focus();
        }
        void DisplayonTextbox(string matg)
        {
            var tacgias = QL.TACGIAs.Where(t => t.MATG == matg);
            if (tacgias != null && tacgias.Count() > 0)
                DisplayonTextbox(tacgias.First());
        }
        void DisplayonTextbox(TACGIA tg)
        {
            txtMaTG.Text = tg.MATG;//
            txtTenTG.Text = tg.TENTG;
        }
        void Delete(string matg)
        {
            var dl = QL.TACGIAs.Where(d => d.MATG == matg);
            if (dl != null)
            {
                TACGIA tg = dl.First();
                QL.TACGIAs.DeleteOnSubmit(tg);
                QL.SubmitChanges();
                OnloadTacGia();
                Cleartext();
            }
            else
                MessageBox.Show("Không tìm thấy sinh viên để xóa", "Thông báo");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            action = ActionType.Them;
            SetButtonEnable(action);
            Cleartext();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "" && txtTenTG.Text == "")
            {
                MessageBox.Show("Không tìm thấy thông tin để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (ListViewtacgia.SelectedItems != null)
                {
                    if (MessageBox.Show("Bạn có muốn xóa hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string matg = ListViewtacgia.SelectedItems[0].SubItems[0].Text;
                        Delete(matg);
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        return;
                }
            }
        }
        CSDLDataContext db = new CSDLDataContext();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool save = true;   //biến save dùng để kiểm tra tính đúng sai
            {
                if (string.IsNullOrEmpty(txtMaTG.Text))
                {
                    error.SetError(txtMaTG, "Mã Tác giả không được để trống");
                    txtMaTG.Focus();
                    save = false;
                }
                else
                    error.SetError(txtMaTG, null);
                if (string.IsNullOrEmpty(txtTenTG.Text))
                {
                    error.SetError(txtTenTG, "Tên Tác giả không được để trống");
                    txtTenTG.Focus();
                    save = false;
                }
                else
                    error.SetError(txtTenTG, null);
                if (!save)
                {
                    MessageBox.Show("Xin kiểm tra lại dữ liệu nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var k = (from u in db.TACGIAs where u.MATG==txtMaTG.Text select u).FirstOrDefault();
                if (k != null)
                {
                    MessageBox.Show("Mã tác giã đã tồn tại","Thông báo");
                    txtMaTG.Focus();
                }
            }
            QL = new CSDLDataContext();
            TACGIA tg = null;
            if (action == ActionType.Them)
            {
                try
                {
                    tg = Gettextbox();
                    QL.TACGIAs.InsertOnSubmit(tg);
                    QL.SubmitChanges();
                    OnloadTacGia();
                    action = ActionType.No;
                    SetButtonEnable(action);
                    MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    txtMaTG.Focus();
                }
               
            }
            else if (action == ActionType.Sua)
            {
                string tacgia = ListViewtacgia.SelectedItems[0].SubItems[0].Text;
                Update(tacgia);
                OnloadTacGia();
                action = ActionType.No;
                SetButtonEnable(action);
                Cleartext();
                //??    MessageBox.Show("Cập nhật thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            action = ActionType.Sua;
            SetButtonEnable(action);
            Cleartext();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            action = ActionType.Huy;
            SetButtonEnable(action);
            Cleartext();
            error.SetError(txtMaTG, null);
            error.SetError(txtTenTG, null);
        }

        private void ListViewtacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewtacgia.SelectedItems.Count > 0)
            {
                DisplayonTextbox(ListViewtacgia.SelectedItems[0].SubItems[0].Text);
            }
        }
    }
}

