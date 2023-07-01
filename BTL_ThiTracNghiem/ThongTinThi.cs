using BTL_ThiTracNghiem.DaTa;
using BTL_ThiTracNghiem.Object;
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
    public partial class ThongTinThi : Form
    {
        public ThongTinThi()
        {
            InitializeComponent();
        }
        private string _laymasv;

        public string laymasv { get { return _laymasv; } set { _laymasv = value; } }

        thiSinhDB tsdb = new thiSinhDB();
        MonThiDB mtdb = new MonThiDB();
        private void ThongTinThi_Load(object sender, EventArgs e)
        {
            hienthongtin();
            loadCBB_Monthi();

        }
        private void hienthongtin()
        {
            ThiSinh ts = tsdb.TTThisinh(_laymasv);
            thongtinma.Text = ts.Masv;
            labelhoten.Text = ts.Tensv;
            labelgtinh.Text = ts.Gtinhsv;
            labelnsinh.Text = ts.NsinhsvString;
            labelLop.Text = ts.Lopsv;

    
        }
        private void loadCBB_Monthi()
        {
            DataTable dt = mtdb.load_monthiexitMade();
            comboBoxmonthiid.DataSource = dt;
            comboBoxmonthiid.DisplayMember = "tenmon";
            comboBoxmonthiid.ValueMember = "mamon";
        }

        private void comboBoxmonthiid_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void comboBoxmonthiid_SelectedValueChanged(object sender, EventArgs e)
        {
            string layvl = comboBoxmonthiid.SelectedValue.ToString();
            int n = mtdb.Made_exitMonThi(layvl);
            dataGridViewmadethimh.Hide();
            
            
            if (n== 1)
            {
                textBoxMadethi.Text = mtdb.Lay1MD(layvl);
                DataTable dt = mtdb.load_monthiexitMadeRamDom(layvl,n);

                dataGridViewmadethimh.DataSource = dt;
            }
            else
            {
                Random r = new Random();
                int mm = r.Next(n);
                
                mm += 1;


                DataTable dtk = mtdb.load_monthiexitMadeRamDom(layvl, mm);

                dataGridViewmadethimh.DataSource = dtk;

                textBoxMadethi.DataBindings.Clear();
                textBoxMadethi.DataBindings.Add("text", dataGridViewmadethimh.DataSource, "madethi");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void buttonLamBai_Click(object sender, EventArgs e)
        {
            string ttten = thongtinma.Text;
            THI thi = new THI(thongtinma.Text, labelhoten.Text, comboBoxmonthiid.Text, textBoxMadethi.Text, comboBoxmonthiid.SelectedValue.ToString());
            thi.Show();
            thi.Activate();
            this.Hide();
        }
    }
}
