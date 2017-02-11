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
    public partial class FQUANLYSACH : Form
    {
        public FQUANLYSACH()
        {
            InitializeComponent();
        }
        CSDLDataContext db = new CSDLDataContext();

        private void btnxem_Click(object sender, EventArgs e)
        {
            viewcapnhatsach.DataSource = from a in db.SACHes
                                         from b in db.TACGIAs
                                         from c in db.THELOAIs
                                         where a.MATG == b.MATG
                                         where a.MATL == c.MATL
                                         select new { a.MASACH, a.TENSACH, a.MATG, a.MATL, a.NAMXB, a.NHAXB };
        }

        private void FQUANLYSACH_Load(object sender, EventArgs e)
        {
            btnxem_Click(sender, e);
        }

        private void search_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (cbloc.Text == "Mã Sách")
            {
                if (search.Text != null)
                {
                    viewcapnhatsach.DataSource = from a in db.SACHes
                                                 from b in db.TACGIAs
                                                 from c in db.THELOAIs
                                                 where a.MATG == b.MATG
                                                 where a.MATL == c.MATL
                                                 where a.MASACH == search.Text
                                                 select new { a.MASACH, a.TENSACH, a.MATG, a.MATL, a.NAMXB, a.NHAXB };
                }
                else if(search.Text==null)
                {
                    btnxem_Click(sender, e);
                }
            }
            if(cbloc.Text=="Tên Sách")
            {
                if (search.Text != null)
                {
                    viewcapnhatsach.DataSource = from a in db.SACHes
                                                 from b in db.TACGIAs
                                                 from c in db.THELOAIs
                                                 where a.MATG == b.MATG
                                                 where a.MATL == c.MATL
                                                 where a.TENSACH == search.Text
                                                 select new { a.MASACH, a.TENSACH, a.MATG, a.MATL, a.NAMXB, a.NHAXB };
                }
            }
        }
    }
}
