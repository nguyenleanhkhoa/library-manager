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
    public partial class FABOUT : Form
    {
        public FABOUT()
        {
            InitializeComponent();
        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void FABOUT_Load(object sender, EventArgs e)
        {
           
            memoEdit1.ReadOnly = true;
            memoEdit1.Properties.AllowFocused = false;
        }
    }
}
