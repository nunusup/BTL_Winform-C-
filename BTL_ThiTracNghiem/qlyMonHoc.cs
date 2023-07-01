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
    public partial class qlyMonHoc : Form
    {
        public qlyMonHoc()
        {
            InitializeComponent();
        }
        MonThiDB mtdb=new MonThiDB();
        KetNoi kn=new KetNoi();
        private void dinhdangluoi()
        {
            dataGridViewmonthi.ReadOnly = true;
            dataGridViewmonthi.Columns[0].HeaderText = "Mã Môn";
            dataGridViewmonthi.Columns[1].HeaderText = "Tên Môn";

        }
        private void showdatamh()
        {
            DataTable data = mtdb.load_monthi();
            dataGridViewmonthi.DataSource = data;
        }
        private void qlyMonHoc_Load(object sender, EventArgs e)
        {
            showdatamh();
            dinhdangluoi();
        }
        private void dataGridViewmonthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxmamon.Text = dataGridViewmonthi.CurrentRow.Cells[0].Value.ToString();
            textBoxtenmon.Text= dataGridViewmonthi.CurrentRow.Cells[1].Value.ToString();

        }
        private void refmo()
        {
            textBoxmamon.Text = "";
            textBoxtenmon.Text = "";
        }
        private void buttonthemmon_Click(object sender, EventArgs e)
        {
            MonThi mt = new MonThi();
            mt.Mamon = textBoxmamon.Text;
            mt.Tenmon = textBoxtenmon.Text;
            int i=mtdb.insert_monthi(mt);
            if (i > 0)
            {
                MessageBox.Show("Thêm môn thi thành công");
                showdatamh();
                refmo();
            }
            else
            {
                MessageBox.Show("Thêm môn thi thất bại");
            }
        }

        private void buttonxoamon_Click(object sender, EventArgs e)
        {
            MonThi mt = new MonThi();
            mt.Mamon = textBoxmamon.Text;
            int i = mtdb.delete_monthi(mt);
            if (i > 0)
            {
                MessageBox.Show("Xóa môn thi thành công");
                showdatamh();
                refmo();
            }
            else
            {
                MessageBox.Show("Xóa môn thi thất bại");
            }
        }

        private void buttonsuamon_Click(object sender, EventArgs e)
        {
            MonThi mt = new MonThi();
            mt.Mamon = textBoxmamon.Text;
            mt.Tenmon = textBoxtenmon.Text;
            int i=mtdb.update_monthi(mt);
            if (i > 0)
            {
                MessageBox.Show("Sửa môn thi thành công");
                showdatamh();
                refmo();
            }
            else
            {
                MessageBox.Show("Sửa môn thi thất bại");
            }
        }

        private void buttontkmom_Click(object sender, EventArgs e)
        {
            string filter = "select mamon ,tenmon  from monhoc where mamon in(select mamon from monhoc) ";
            if (!string.IsNullOrEmpty(textBoxmamon.Text.Trim()))
            {
                filter += string.Format("AND mamon like N'%{0}%'", textBoxmamon.Text);
            }
            if (!string.IsNullOrEmpty(textBoxtenmon.Text.Trim()))
            {
                filter += string.Format("AND tenmon like N'%{0}%'", textBoxtenmon.Text);
            }
            
            DataTable dt = kn.Load_DataNotProc(filter);
            dataGridViewmonthi.DataSource = dt;
        }

        private void buttonqlymade_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showdatamh();
            refmo();
        }
    }
}
