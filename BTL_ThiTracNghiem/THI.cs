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
    public partial class THI : Form
    {
        private THI()
        {
            InitializeComponent();
        }
        
        PhieuDiemDB pddb=new PhieuDiemDB();
        CauHoiDB chdb = new CauHoiDB();

        private DataTable _dataTable;
        private int _nQuestion;
        private int _phut;

        public int Phut
        {
            get { return _phut; }
            set { _phut = value; }
        }
        public int giay = 0;
        

        private int _cursorIndex;
        private int[] _resultAns;
        private string _idStudent;

        string mamon;
        public DataTable Table
        {
            get => this._dataTable;
            set => this._dataTable = value;
        }
        public string IdStudent
        {
            get => this._idStudent;
            set => this._idStudent = value;
        }

        public int[] Answers => _resultAns;
        public int Count
        {
            get => this._nQuestion;
            set => _nQuestion = value;
        }
        
        public THI(string ma, string ten, string mon, string de, string mm):this()
        {
            lbMasv.Text = ma;
            lbhoten.Text = ten;
            lbtenmon.Text = mon;
            lbmade.Text = de;
            mamon = mm;

            Phut = 1;
 
            labelTimeCk.Text = string.Format("{0}:{1}", Phut.ToString().PadLeft(2, '0'),giay.ToString().PadLeft(2, '0'));

            //timer1.Start();
            CauHoi ch = new CauHoi();
            ch.MaMThiChoi = mamon;
            ch.MDThiChoi= lbmade.Text;

            Table = chdb.loadCauhoiLamBai(ch);

            Count = Table.Rows.Count;

            _resultAns=new int[Count];

            SetButtonFlow(Count);

            rickNdung.ReadOnly = true;
            richTextBoxA.ReadOnly = true;
            richTextBoxB.ReadOnly = true;
            richTextBoxC.ReadOnly = true;
            richTextBoxD.ReadOnly = true;
        }

        private void SetButtonFlow(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Button bt = new Button();
                bt.Size = new System.Drawing.Size(50, 50);
                bt.Text = "QUES" + i;
                bt.Name = "" + i;
                bt.BackColor = Color.Orange;
                bt.FlatStyle = FlatStyle.Flat;
                bt.FlatAppearance.BorderSize = 2;
                bt.FlatAppearance.BorderColor = Color.White;
                bt.Click += btnFlow_Click;
                flowLayoutPanel1.Controls.Add(bt);
            }
        }

        private void btnFlow_Click(object sender, EventArgs e)
        {
            int old = _cursorIndex;
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                if (flowLayoutPanel1.Controls[i] == sender)
                {
                    _cursorIndex = i;
                    break;
                }
            DisplayQuestion(_cursorIndex);
            FocusSelectedQues(old, _cursorIndex);
        }

        private void FocusSelectedQues(int oldID, int newID)
        {
            if (oldID == newID)
            {
                Button newBtn_ = (Button)flowLayoutPanel1.Controls[newID];
                newBtn_.FlatAppearance.BorderColor = Color.Red;
                return;
            }
            Button oldBtn = (Button)flowLayoutPanel1.Controls[oldID];
            oldBtn.FlatAppearance.BorderColor = Color.White;
            Button newBtn = (Button)flowLayoutPanel1.Controls[newID];
            newBtn.FlatAppearance.BorderColor = Color.Red;
        }

        private void DisplayQuestion(int index_row)
        {
            
            DataRow row = _dataTable.Rows[index_row];
            rickNdung.Text = string.Format(CauHoi._FORMAT_QUESTION, index_row + 1,Count, row["noidung"]);
            richTextBoxA.Text = (string)row["DA1"];
            richTextBoxB.Text = (string)row["DA2"];
            richTextBoxC.Text = (string)row["DA3"];
            richTextBoxD.Text = (string)row["DA4"];
            CheckAns(index_row);
        }

        private bool CheckAns(int index_row)
        {
            int pos_ans = _resultAns[index_row];
            switch (pos_ans)
            {
                case 0:
                    radioButtonA.Checked = false;
                    radioButtonB.Checked = false;
                    radioButtonC.Checked = false;
                    radioButtonD.Checked = false;
                    break;
                case 1:
                    radioButtonA.Checked = true;
                    break;
                case 2:
                    radioButtonB.Checked = true;
                    break;
                case 3:
                    this.radioButtonC.Checked = true;
                    break;
                case 4:
                    radioButtonD.Checked = true;
                    break;
                default:
                    break;
            }
            return pos_ans > 0;
        }

        private void THI_Load(object sender, EventArgs e)
        {
            if (Count <= 0)
            {
                MessageBox.Show("ma de nay hien chua co cau hoi");
                Login lg = new Login();
                lg.Show();
                lg.Activate();
                this.Close();
            }
            else
            {
                DisplayQuestion(_cursorIndex);
                FocusSelectedQues(0, 0);
                timer1.Enabled = true;
            }
               
        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            if (_cursorIndex >= 1)
            {
                int old = _cursorIndex;
                _cursorIndex--;
                DisplayQuestion(_cursorIndex);
                FocusSelectedQues(old, _cursorIndex);
               
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_cursorIndex < Count - 1)
            {
                int old = _cursorIndex;
                _cursorIndex++;
                DisplayQuestion(_cursorIndex);
                FocusSelectedQues(old, _cursorIndex);
            }
        }

        private void buttonNopBai_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show
                (this, "ban co muon nop bai", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Submitted();
            }
        }

        private void Submitted()
        {
            int tongcau = Count;
            int caudung ;
            int causai ;

            int count = 0;
            for (int a = 0; a < Answers.Length; a++)
            {
                if (Answers[a] == (int)Table.Rows[a]["DAPANCK"])
                    count++;
            }
            caudung= count;
            causai = tongcau - caudung;
            float point = (float)(count * 10) / Count;

            PhieuDiem pd=new PhieuDiem();
            pd.MaMonPhieu= mamon;
            pd.MaDePhieu = lbmade.Text;
            pd.MaSinhVienThi= lbMasv.Text;
            pd.Tongcau = tongcau;
            pd.Caudung = caudung;
            pd.Causai = causai;
            pd.Tongdiem = point;

            int i=pddb.insert_PhieuDiem(pd);
            if (i > 0)
            {
                MessageBox.Show("Số điểm" +point + "\n dung" + caudung+ "\n Sai" + causai + "\n tong cau" + tongcau);
                Login lg = new Login();
                lg.Show();
                lg.Activate();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lưu điểm thất bại");
            }
           
        }

        private void radioButtonA_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls[_cursorIndex].BackColor = Color.Green;
            _resultAns[_cursorIndex] = 1;
        }

        private void radioButtonB_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls[_cursorIndex].BackColor = Color.Green;
            _resultAns[_cursorIndex] = 2;
        }

        private void radioButtonC_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls[_cursorIndex].BackColor = Color.Green;
            _resultAns[_cursorIndex] = 3;
        }

        private void radioButtonD_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls[_cursorIndex].BackColor = Color.Green;
            _resultAns[_cursorIndex] = 4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            giay--;
            if (giay == -1)
            {
                giay = 59;
                Phut--;
            }
            if (Phut == -1)
            {
                timer1.Stop();
                MessageBox.Show("Hết thời gian làm bài.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                labelTimeCk.Text = "00:00";
                Submitted();
            }else
                labelTimeCk.Text = string.Format("{0}:{1}", Phut.ToString().PadLeft(2, '0'), giay.ToString().PadLeft(2, '0'));
        }
    }
}
