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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {

        }

        CodeLoginDB dbcheck=new CodeLoginDB();

        private void batdau_Click(object sender, EventArgs e)
        {
            CodeLogin cd=new CodeLogin();
            string mac= txtcode.Text.Trim();
            int check = dbcheck.check_dangnhap(mac);
            if (rdquanlyck.Checked)
            {
                if (mac== "Admin")
                {
                    QuanLyThiTN qlthi = new QuanLyThiTN();
                    qlthi.Show();
                    qlthi.Activate();
                    this.Hide();
                }
                else
                {
                    DialogResult loi = MessageBox.Show("Sai Mã Đăng Nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rdsinhvienck.Checked)
            {
                if (check == 1)
                {
                    ThongTinThi tt = new ThongTinThi();
                    tt.laymasv = txtcode.Text.Trim();
                    tt.Show();
                    tt.Activate();
                    this.Hide();
                }
                else
                {
                    DialogResult loi = MessageBox.Show("Sai Mã Sinh Viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
              
            }
            else
            {
                DialogResult loi = MessageBox.Show("Thiếu Quyền Đăng Nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtcode_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider re=new ErrorProvider();
            if(txtcode.Text == "")
            {
                re.SetError(txtcode, "Mã đăng nhập không để trống");
                return;
            }
            else
            {
                re.SetError(txtcode, "");
            }
        }
    }
}
