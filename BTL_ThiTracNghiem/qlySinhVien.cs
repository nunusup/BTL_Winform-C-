using BTL_ThiTracNghiem.DaTa;
using BTL_ThiTracNghiem.Object;
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

namespace BTL_ThiTracNghiem
{
    public partial class qlySinhVien : Form
    {
        public qlySinhVien()
        {
            InitializeComponent();
        }

        KetNoi kn=new KetNoi();
        thiSinhDB tsdb=new thiSinhDB();
        private void dinhdangluoi()
        {
            dgThiSinh.ReadOnly = true;
            dgThiSinh.Columns[0].HeaderText = "Mã Sinh Viên";
            dgThiSinh.Columns[1].HeaderText = "Tên Sinh Viên";
            dgThiSinh.Columns[2].HeaderText = "Giới Tính";
            dgThiSinh.Columns[3].HeaderText = "Ngày Sinh";
            dgThiSinh.Columns[4].HeaderText = "Lớp";

        }
        private void show_dgsv()
        {
            DataTable dt = tsdb.load_thissinh();
            dgThiSinh.DataSource =dt ;
        }

        private void qlySinhVien_Load(object sender, EventArgs e)
        {          
            show_dgsv();
            dinhdangluoi();
        }

        private void dgThiSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // buttonThemsv.Enabled = false;
           // textBoxmasv.Enabled = false;
            textBoxmasv.Text = dgThiSinh.CurrentRow.Cells[0].Value.ToString();
            textBoxtensv.Text = dgThiSinh.CurrentRow.Cells[1].Value.ToString(); 
            string gt=dgThiSinh.CurrentRow.Cells[2].Value.ToString();
            if (gt == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else if(gt == "Nữ")
            {
                radioButtonNu.Checked = true;
            }
            //dateTimePickerNSinh.Text = Convert.ToString( dgThiSinh.CurrentRow.Cells[3].Value.ToString());
            textBoxlop.Text = dgThiSinh.CurrentRow.Cells[4].Value.ToString();
        }
        private void refresh()
        {
            textBoxmasv.Text = "";
            textBoxtensv.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            dateTimePickerNSinh.Value = DateTime.Now;
            textBoxlop.Text = "";
        }
        private void buttonThemsv_Click(object sender, EventArgs e)
        {
            ThiSinh ts = new ThiSinh();
            ts.Masv = textBoxmasv.Text;
            ts.Tensv = textBoxtensv.Text;
            String gtinh = "";
            if (radioButtonNam.Checked == true)
            {
                gtinh = "Nam";
            }
            else if (radioButtonNu.Checked == true)
            {
                gtinh = "Nữ";
            }
            ts.Gtinhsv = gtinh;
            ts.Nsinhsv = DateTime.Parse(dateTimePickerNSinh.Text);
            ts.Lopsv = textBoxlop.Text;
            int i = tsdb.insert_thisinh(ts);
            if (i > 0)
            {
                MessageBox.Show("Thêm sinh viên thành công");
                show_dgsv();
                refresh();
            }
            else
            {
                MessageBox.Show("Thêm sinh viên thất bại");
            }
        
        }
        
        private void buttonsuasv_Click(object sender, EventArgs e)
        {
            ThiSinh ts = new ThiSinh();
            ts.Masv = textBoxmasv.Text;
            ts.Tensv = textBoxtensv.Text;
            String gtinh = "";
            if (radioButtonNam.Checked == true)
            {
                gtinh = "Nam";
            }
            else if (radioButtonNu.Checked == true)
            {
                gtinh = "Nữ";
            }
            ts.Gtinhsv = gtinh;
            ts.Nsinhsv = DateTime.Parse(dateTimePickerNSinh.Text);
            ts.Lopsv = textBoxlop.Text;
            int i = tsdb.update_thisinh(ts);
            if (i > 0)
            {
                MessageBox.Show("Sửa sinh viên thành công");
                show_dgsv();
                refresh();
            }
            else
            {
                MessageBox.Show("Sửa sinh viên thất bại");
            }
        }

        private void buttonxoasv_Click(object sender, EventArgs e)
        {
            ThiSinh ts = new ThiSinh();
            ts.Masv = textBoxmasv.Text;
            int i = tsdb.delete_thisinh(ts);
            if (i > 0)
            {
                MessageBox.Show("Sửa sinh viên thành công");
                show_dgsv();
                refresh();
            }
            else
            {
                MessageBox.Show("Sửa sinh viên thất bại");
            }
        }

        private void buttontimkiemsv_Click(object sender, EventArgs e)
        {
            
            
            string filter = "select mats ,tents ,gtinhts,nsinhts,lopts from thisinh where mats in(select mats from thisinh) ";
            if (!string.IsNullOrEmpty(textBoxmasv.Text.Trim()))
            {
                filter += string.Format("AND mats like N'%{0}%'", textBoxmasv.Text);
            }
            if (!string.IsNullOrEmpty(textBoxtensv.Text.Trim()))
            {
                filter += string.Format("AND tents like N'%{0}%'", textBoxtensv.Text);
            }
            if (!string.IsNullOrEmpty(textBoxlop.Text.Trim()))
            {
                filter += string.Format("AND lopts like N'%{0}%'", textBoxlop.Text);
            }
            string gtt = "";
            if (radioButtonNu.Checked == true)
            {
                gtt = "Nữ";
                filter += string.Format("AND gtinhts = N'{0}'",gtt);
            }
            if (radioButtonNam.Checked == true)
            {
                gtt = "Nam";
                filter += string.Format("AND gtinhts = '{0}'", gtt);
            }
            DataTable dt = kn.Load_DataNotProc(filter);
            dgThiSinh.DataSource = dt;


        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_dgsv();
            refresh();
        }
    }
}
