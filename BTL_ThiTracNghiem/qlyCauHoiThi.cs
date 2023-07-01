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
    public partial class qlyCauHoiThi : Form
    {
        public qlyCauHoiThi()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        MaThiDB mthidb = new MaThiDB();
        MonThiDB mtdb = new MonThiDB();
        CauHoiDB chdb = new CauHoiDB();
        private void dinhdangluoi()
        {
            dataGridViewCauHoiThi.ReadOnly = true;
            dataGridViewCauHoiThi.Columns[0].HeaderText = "Mã Câu";
            dataGridViewCauHoiThi.Columns[1].HeaderText = "Nội dung";
            dataGridViewCauHoiThi.Columns[2].HeaderText = "Đáp Án A";
            dataGridViewCauHoiThi.Columns[3].HeaderText = "Đáp Án B";
            dataGridViewCauHoiThi.Columns[4].HeaderText = "Đáp Án C";
            dataGridViewCauHoiThi.Columns[5].HeaderText = "Đáp Án D";
            dataGridViewCauHoiThi.Columns[6].HeaderText = "Đáp Án đúng";
            dataGridViewCauHoiThi.Columns[7].HeaderText = "Tên Môn";
            dataGridViewCauHoiThi.Columns[8].HeaderText = "Mã đề";

        }
        private void show_dgsv()
        {
            DataTable dt = chdb.load_CauHoi();
            dataGridViewCauHoiThi.DataSource = dt;
        }
        private void qlyCauHoiThi_Load(object sender, EventArgs e)
        {
            show_dgsv();
            dinhdangluoi();
            loadCBB_Monthi();
        }
        private void loadCBB_Monthi()
        {
            DataTable dt = mtdb.load_monthiexitMade();
            comboBoxMonThi.DataSource = dt;
            comboBoxMonThi.DisplayMember = "tenmon";
            comboBoxMonThi.ValueMember = "mamon";
        }

        private void dataGridViewCauHoiThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDCau.Text = dataGridViewCauHoiThi.CurrentRow.Cells[0].Value.ToString();
            richTextNdung.Text = dataGridViewCauHoiThi.CurrentRow.Cells[1].Value.ToString();
            richTextBoxA.Text = dataGridViewCauHoiThi.CurrentRow.Cells[2].Value.ToString();
            richTextBoxB.Text = dataGridViewCauHoiThi.CurrentRow.Cells[3].Value.ToString();
            richTextBoxC.Text = dataGridViewCauHoiThi.CurrentRow.Cells[4].Value.ToString();
            richTextBoxD.Text = dataGridViewCauHoiThi.CurrentRow.Cells[5].Value.ToString();
            int ck = Convert.ToInt32(dataGridViewCauHoiThi.CurrentRow.Cells[6].Value.ToString());
            if (ck == 1)
            {
                radioButtonDa1.Checked = true;
            }
            if (ck == 2)
            {
                radioButtonDa2.Checked = true;
            }
            if (ck == 3)
            {
                radioButtonDa3.Checked = true;
            }
            if (ck ==4)
            {
                radioButtonDa4.Checked = true;
            }
            comboBoxMonThi.Text = dataGridViewCauHoiThi.CurrentRow.Cells[7].Value.ToString();
            comboBoxMaDe.Text = dataGridViewCauHoiThi.CurrentRow.Cells[8].Value.ToString();

        }

        private void comboBoxMonThi_SelectedValueChanged(object sender, EventArgs e)
        {
            string layvl = comboBoxMonThi.SelectedValue.ToString();
            DataTable dt = mthidb.load_MadeexecMonthi(layvl);
            comboBoxMaDe.DataSource = dt;
            comboBoxMaDe.DisplayMember = "madethi";
            comboBoxMaDe.ValueMember = "madethi";
        }

        public void RFe()
        {
            textBoxIDCau.Text = "";
            richTextNdung.Text = "";
            richTextBoxA.Text = "";
            richTextBoxB.Text = "";
            richTextBoxC.Text = "";
            richTextBoxD.Text = "";
            radioButtonDa1.Checked = false;
            radioButtonDa2.Checked = false;
            radioButtonDa3.Checked = false;
            radioButtonDa4.Checked = false;
        }

        private void buttonThemCau_Click(object sender, EventArgs e)
        {
            Boolean ck = ckeckrd();
            if (ck == false)
            {
                MessageBox.Show("Thiếu Đáp Án Đúng");
            }
            else
            {
                CauHoi ch = new CauHoi();
                ch.Ndung = richTextNdung.Text;
                ch.Da1 = richTextBoxA.Text;
                ch.Da2 = richTextBoxB.Text;
                ch.Da3 = richTextBoxC.Text;
                ch.Da4 = richTextBoxD.Text;
                if (radioButtonDa1.Checked == true)
                {
                    
                    ch.DaRCheck = 1;
                }
                if (radioButtonDa2.Checked == true)
                {
                    
                    ch.DaRCheck = 2;
                }
                if (radioButtonDa3.Checked == true)
                {
                    
                    ch.DaRCheck = 3;
                }
                if (radioButtonDa4.Checked == true)
                {
                    
                    ch.DaRCheck = 4;
                }
                ch.MaMThiChoi = (string)comboBoxMonThi.SelectedValue;
                ch.MDThiChoi = (string)comboBoxMaDe.SelectedValue;
                int i = chdb.insert_CauHoi(ch);
                if (i > 0)
                {
                    MessageBox.Show("Thêm câu hỏi thành công");
                    show_dgsv();
                    dinhdangluoi();
                    RFe();
                }
                else
                {
                    MessageBox.Show("Thêm câu hỏi thất bại");
                }
            }


        }

        public Boolean ckeckrd()
        {
            Boolean ck = false;
            if (radioButtonDa1.Checked == true)
            {
                ck = true;
            }
            if (radioButtonDa2.Checked == true)
            {
                ck = true;
            }
            if (radioButtonDa3.Checked == true)
            {
                ck = true;
            }
            if (radioButtonDa4.Checked == true)
            {
                ck = true;
            }
            return ck;
        }

        private void buttonXoaCau_Click(object sender, EventArgs e)
        {
            CauHoi ch = new CauHoi();
            ch.MaChoi = textBoxIDCau.Text;
            int i = chdb.delete_CauHoi(ch);
            if (i > 0)
            {
                MessageBox.Show("Xóa câu hỏi thành công");
                show_dgsv();
                dinhdangluoi();
                RFe();
            }
            else
            {
                MessageBox.Show("Xóa câu hỏi thất bại");
            }
        }


        private void buttonSuaCau_Click(object sender, EventArgs e)
        {
            Boolean ck = ckeckrd();
            if (ck == false)
            {
                MessageBox.Show("Thiếu Đáp Án Đúng");
            }
            else
            {
                CauHoi ch = new CauHoi();
                ch.MaChoi= textBoxIDCau.Text;
                ch.Ndung = richTextNdung.Text;
                ch.Da1 = richTextBoxA.Text;
                ch.Da2 = richTextBoxB.Text;
                ch.Da3 = richTextBoxC.Text;
                ch.Da4 = richTextBoxD.Text;
                if (radioButtonDa1.Checked == true)
                {

                    ch.DaRCheck = 1;
                }
                if (radioButtonDa2.Checked == true)
                {

                    ch.DaRCheck = 2;
                }
                if (radioButtonDa3.Checked == true)
                {

                    ch.DaRCheck = 3;
                }
                if (radioButtonDa4.Checked == true)
                {

                    ch.DaRCheck = 4;
                }
                ch.MaMThiChoi = (string)comboBoxMonThi.SelectedValue;
                ch.MDThiChoi = (string)comboBoxMaDe.SelectedValue;
                int i = chdb.update_CauHoi(ch);
                if (i > 0)
                {
                    MessageBox.Show("Sửa câu hỏi thành công");
                    show_dgsv();
                    dinhdangluoi();
                    RFe();
                }
                else
                {
                    MessageBox.Show("Sửa câu hỏi thất bại");
                }
            }
        }

        private void buttonTimCau_Click(object sender, EventArgs e)
        {
            string filter = "select macau, noidung ,DA1 ,DA2 ,DA3 ,DA4 ,DAPANCK ,monhoc.tenmon ,MADETHI from cauhoi,monhoc where cauhoi.mamonhoc = monhoc.mamon ";
            if (!string.IsNullOrEmpty(textBoxIDCau.Text.Trim()))
            {
                filter += string.Format("AND macau like N'%{0}%'", textBoxIDCau.Text);
            }
            if (!string.IsNullOrEmpty(richTextNdung.Text.Trim()))
            {
                filter += string.Format("AND noidung like N'%{0}%'", richTextNdung.Text);
            }
            if (!string.IsNullOrEmpty(richTextBoxA.Text.Trim()))
            {
                filter += string.Format("AND DA1 like N'%{0}%'", richTextBoxA.Text);
            }
            if (!string.IsNullOrEmpty(richTextBoxB.Text.Trim()))
            {
                filter += string.Format("AND DA2 like N'%{0}%'", richTextBoxB.Text);
            }
            if (!string.IsNullOrEmpty(richTextBoxC.Text.Trim()))
            {
                filter += string.Format("AND DA3 like N'%{0}%'", richTextBoxC.Text);
            }
            if (!string.IsNullOrEmpty(richTextBoxD.Text.Trim()))
            {
                filter += string.Format("AND DA4 like N'%{0}%'", richTextBoxD.Text);
            }
            int daR;
            if (radioButtonDa1.Checked == true)
            {
                daR= 1;
                filter += string.Format("AND DAPANCK = N'{0}'", daR);
            }
            if (radioButtonDa2.Checked == true)
            {
                daR =2;
                filter += string.Format("AND DAPANCK = N'{0}'", daR);
            }
            if (radioButtonDa3.Checked == true)
            {
                daR = 3;
                filter += string.Format("AND DAPANCK = N'{0}'", daR);
            }
            if (radioButtonDa4.Checked == true)
            {
                daR = 4;
                filter += string.Format("AND DAPANCK = N'{0}'", daR);
            }
            
            filter += string.Format("AND mamonhoc like N'%{0}%'", comboBoxMonThi.SelectedValue.ToString());
            filter += string.Format("AND MADETHI like N'%{0}%'", comboBoxMaDe.SelectedValue.ToString());

            DataTable dt = kn.Load_DataNotProc(filter);
            dataGridViewCauHoiThi.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_dgsv();
            dinhdangluoi();
            RFe();
        }
    }
}
