using BTL_ThiTracNghiem.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.DaTa
{
    internal class CodeLoginDB
    {
        KetNoi ketnoi=new KetNoi();
        public int check_dangnhap(string codeTS)
        {
            string sql = "SELECT COUNT(*) FROM thisinh WHERE mats=N'" + codeTS + "'";
            return ketnoi.rtInteger(sql);
        }

        
    }
}
