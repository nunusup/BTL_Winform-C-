using BTL_ThiTracNghiem.DaTa;
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
    public partial class QlyKetQuaThics : Form
    {
        public QlyKetQuaThics()
        {
            InitializeComponent();
        }
        PhieuDiemDB pddb = new PhieuDiemDB();
        KetNoi kn=new KetNoi();
        private void dinhdangluoi()
        {
            dataGridViewKetQua.ReadOnly = true;
            dataGridViewKetQua.Columns[0].HeaderText = "Mã Phiếu";
            dataGridViewKetQua.Columns[1].HeaderText = "Môn Thi";
            dataGridViewKetQua.Columns[2].HeaderText = "Mã đề";
            dataGridViewKetQua.Columns[3].HeaderText = "Tên Thí Sinh";
            dataGridViewKetQua.Columns[4].HeaderText = "Lớp";
            dataGridViewKetQua.Columns[5].HeaderText = "Tổng Số câu";
            dataGridViewKetQua.Columns[6].HeaderText = "Số câu đúng";
            dataGridViewKetQua.Columns[7].HeaderText = "Số câu sai";
            dataGridViewKetQua.Columns[8].HeaderText = "Tổng điểm";

        }
        private void show_dgpd()
        {
            DataTable dt = pddb.load_PhieuDiem();
            dataGridViewKetQua.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaPhieu.Text = dataGridViewKetQua.CurrentRow.Cells[0].Value.ToString();
            textBoxTenM.Text= dataGridViewKetQua.CurrentRow.Cells[1].Value.ToString();
            textBoxMDeP.Text= dataGridViewKetQua.CurrentRow.Cells[2].Value.ToString();
            textBoxThiS.Text=dataGridViewKetQua.CurrentRow.Cells[3].Value.ToString();
            textBoxLopT.Text= dataGridViewKetQua.CurrentRow.Cells[4].Value.ToString();
            textBoxTongC.Text= dataGridViewKetQua.CurrentRow.Cells[5].Value.ToString();
            textBoxCauD.Text= dataGridViewKetQua.CurrentRow.Cells[6].Value.ToString();
            textBoxCauS.Text=dataGridViewKetQua.CurrentRow.Cells[7].Value.ToString();
            textBoxTongD.Text= dataGridViewKetQua.CurrentRow.Cells[8].Value.ToString();
        }

        private void QlyKetQuaThics_Load(object sender, EventArgs e)
        {
            show_dgpd();
            dinhdangluoi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonTimKiem_Click_1(object sender, EventArgs e)
        {
            string filter = "select maphieudiem,monhoc.tenmon,iddethi.madethi,thisinh.tents,thisinh.lopts,tongsocau,socaudung,socausai,tongdiem from phieudiem, iddethi, monhoc, thisinh where phieudiem.maDethi = iddethi.madethi and phieudiem.maMonthi = monhoc.mamon and phieudiem.matsinh = thisinh.mats";
            if (!string.IsNullOrEmpty(textBoxMaPhieu.Text.Trim()))
            {
                filter += string.Format("AND maphieudiem ={0}", textBoxMaPhieu.Text);
               
            }
            if (!string.IsNullOrEmpty(textBoxTenM.Text.Trim()))
            {
                filter += string.Format("AND monhoc.tenmon like N'%{0}%'", textBoxTenM.Text);
               
            }
            if (!string.IsNullOrEmpty(textBoxMDeP.Text.Trim()))
            {
                filter += string.Format("AND iddethi.madethi like N'%{0}%'", textBoxMDeP.Text);
            }
            if (!string.IsNullOrEmpty(textBoxThiS.Text.Trim()))
            {
                filter += string.Format("AND thisinh.tents like N'%{0}%'", textBoxThiS.Text);
            }
            if (!string.IsNullOrEmpty(textBoxLopT.Text.Trim()))
            {
                filter += string.Format("AND thisinh.lopts like N'%{0}%'", textBoxLopT.Text);
            }
            if (!string.IsNullOrEmpty(textBoxTongC.Text.Trim()))
            {
                filter += string.Format("AND tongsocau like N'%{0}%'", textBoxTongC.Text);
            }
            if (!string.IsNullOrEmpty(textBoxCauD.Text.Trim()))
            {
                filter += string.Format("AND socaudung like N'%{0}%'", textBoxCauD.Text);
            }
            if (!string.IsNullOrEmpty(textBoxCauS.Text.Trim()))
            {
                filter += string.Format("AND socausai like N'%{0}%'", textBoxCauS.Text);
            }
            if (!string.IsNullOrEmpty(textBoxTongD.Text.Trim()))
            {
                filter += string.Format("AND tongdiem like N'%{0}%'", textBoxTongD.Text);
            }

            DataTable dt=kn.Load_DataNotProc(filter);
            dataGridViewKetQua.DataSource = dt;
            dinhdangluoi();
        }
    }
}
