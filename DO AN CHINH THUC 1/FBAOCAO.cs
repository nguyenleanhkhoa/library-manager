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
    public partial class FBAOCAO : Form
    {
        public FBAOCAO()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             //   this.bAOCAOTableAdapter.Fill(this.rEPORT.BAOCAO, tRANGTHAIToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FBAOCAO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BaoCao.BAOCAO' table. You can move, or remove it, as needed.
   //         this.BAOCAOTableAdapter.Fill(this.BaoCao.BAOCAO);

            this.reportViewer1.RefreshReport();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            this.BAOCAOTableAdapter.Fill(this.BaoCao.BAOCAO,cbTrangThai.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
