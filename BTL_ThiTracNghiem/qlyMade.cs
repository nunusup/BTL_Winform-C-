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
    public partial class qlyMade : Form
    {
        MonThiDB mtdb=new MonThiDB();
        MaThiDB MaThiDB = new MaThiDB();
        KetNoi kn = new KetNoi();
        public qlyMade()
        {
            InitializeComponent();
        }
        private void dinhdangluoi()
        {
            dataGridViewmade.ReadOnly = true;
            dataGridViewmade.Columns[0].HeaderText = "Mã Đề";
            dataGridViewmade.Columns[1].HeaderText = "Tên Môn";

        }
        private void showdatamade()
        {
            DataTable data = MaThiDB.load_made();
            dataGridViewmade.DataSource = data;
        }

        private void loadCBB_Monthi()
        {
            DataTable dt = mtdb.load_monthi();
            comboBoxmamon.DataSource = dt;
            comboBoxmamon.DisplayMember = "tenmon";
            comboBoxmamon.ValueMember = "mamon";
        }
        private void qlyMade_Load(object sender, EventArgs e)
        {
            loadCBB_Monthi();
            showdatamade();
            dinhdangluoi();
        }
        
        private void buttonthemde_Click(object sender, EventArgs e)
        {
            MaThics mt=new MaThics();
            mt.Made = textBoxmade.Text;
            int a=comboBoxmamon.SelectedIndex;
            mt.MaMont = (String)comboBoxmamon.SelectedValue;
            int i = MaThiDB.insert_made(mt);
            if (i > 0)
            {
                MessageBox.Show("Thêm Mã đề thành công");
                showdatamade();
                textBoxmade.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm Mã đề thất bại");
            }
        }

        private void buttonsuamde_Click(object sender, EventArgs e)
        {
            MaThics mt = new MaThics();
            mt.Made = textBoxmade.Text;
            mt.MaMont = (String)comboBoxmamon.SelectedValue;
            int i = MaThiDB.update_made(mt);
            if (i > 0)
            {
                MessageBox.Show("Sửa Mã đề thành công");
                showdatamade();
                textBoxmade.Text = "";
            }
            else
            {
                MessageBox.Show("Sửa Mã đề thất bại");
            }
        }

        private void buttontkde_Click(object sender, EventArgs e)
        {
            string filter = "select madethi,tenmon from iddethi,monhoc where iddethi.mamonthi = monhoc.mamon ";
            if (!string.IsNullOrEmpty(textBoxmade.Text.Trim()))
            {
                filter += string.Format("AND iddethi.madethi like N'%{0}%'", textBoxmade.Text);
            }
            if (comboBoxmamon.SelectedIndex >0)
            {
                filter += string.Format("AND monhoc.mamon = N'{0}'", comboBoxmamon.SelectedValue.ToString());
            }
            
            DataTable dt = kn.Load_DataNotProc(filter);
            dataGridViewmade .DataSource = dt;
        }

        private void buttonxoade_Click(object sender, EventArgs e)
        {
            MaThics mt = new MaThics();
            mt.Made = textBoxmade.Text;
            int i = MaThiDB.delete_made(mt);
            if (i > 0)
            {
                MessageBox.Show("Xóa Mã đề thành công");
                showdatamade();
                textBoxmade.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa Mã đề thất bại");
            }
        }

        private void dataGridViewmade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxmade.Text = dataGridViewmade.CurrentRow.Cells[0].Value.ToString();
            comboBoxmamon.Text =dataGridViewmade.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showdatamade();
            textBoxmade.Text = "";
        }
    }
}
