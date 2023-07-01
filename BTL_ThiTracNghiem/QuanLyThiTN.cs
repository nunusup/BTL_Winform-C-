using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_ThiTracNghiem
{
    public partial class QuanLyThiTN : Form
    {
        public QuanLyThiTN()
        {
            InitializeComponent();
        }
        private Form findForm(string name)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                    return f;
            }
            return null;
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findForm("qlySinhVien");
            Form sv = new qlySinhVien();
            if (f == null)
            {
                sv.MdiParent = this;
                sv.Show();
            }
            else
                sv.Activate();
        }

        private void quảnLýMônThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findForm("qlyMonHoc");
            Form mh = new qlyMonHoc();
            if (f == null)
            {
                mh.MdiParent = this;
                mh.Show();
            }
            else
                mh.Activate();
        }

        private void quảnLýCâuHỏiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findForm("qlyCauHoiThi");
            Form ch = new qlyCauHoiThi();
            if (f == null)
            {
                ch.MdiParent = this;
                ch.Show();
            }
            else
                ch.Activate();
        }

        private void kếtQuảThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findForm("QlyKetQuaThics");
            Form kq = new QlyKetQuaThics();
            if (f == null)
            {
                kq.MdiParent = this;
                kq.Show();
            }
            else
                kq.Activate();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void quảnLýĐềiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form f = findForm("qlyMade");
            Form kq = new qlyMade();
            if (f == null)
            {
                kq.MdiParent = this;
                kq.Show();
            }
            else
                kq.Activate();
        }
    }
}
