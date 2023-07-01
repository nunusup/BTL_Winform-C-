using BTL_ThiTracNghiem.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.DaTa
{
    internal class thiSinhDB
    {
        KetNoi ketnoi = new KetNoi();
        
        public DataTable load_thissinh()
        {
            string sql = "load_thisinh";
            return ketnoi.Load_Data(sql);
        }

        public int insert_thisinh(ThiSinh tsinh)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            name[1] = "@TENTHISINH";
            name[2] = "@GIOITINH";
            name[3] = "@NGAYSINH";
            name[4] = "@LOP";
            values[0] = tsinh.Masv;
            values[1] = tsinh.Tensv;
            values[2] = tsinh.Gtinhsv;
            values[3] = tsinh.Nsinhsv;
            values[4] = tsinh.Lopsv;
            string sql = "Insert_ThiSinh";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int update_thisinh(ThiSinh tsinh)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            name[1] = "@TENTHISINH";
            name[2] = "@GIOITINH";
            name[3] = "@NGAYSINH";
            name[4] = "@LOP";
            values[0] = tsinh.Masv;
            values[1] = tsinh.Tensv;
            values[2] = tsinh.Gtinhsv;
            values[3] = tsinh.Nsinhsv;
            values[4] = tsinh.Lopsv;
            string sql = "Update_ThiSinh";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int delete_thisinh(ThiSinh tsinh)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            values[0] = tsinh.Masv;
            string sql = "Delete_ThiSinh";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        

        public ThiSinh TTThisinh(string mats)
        {
            string sqlma = "SELECT mats FROM thisinh WHERE mats='" + mats + "'";
            string sqlten = "SELECT tents FROM thisinh WHERE mats='" + mats + "'";
            string sqlgtinh = "SELECT gtinhts FROM thisinh WHERE mats='" + mats + "'";
            string sqlnams = "SELECT nsinhts FROM thisinh WHERE mats='" + mats + "'";
            string sqllop = "SELECT lopts FROM thisinh WHERE mats='" + mats + "'";
            return ketnoi.rtobjTS(sqlma,sqlten, sqlgtinh, sqlnams, sqllop);
        }
    }
}
