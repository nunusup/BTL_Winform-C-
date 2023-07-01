using BTL_ThiTracNghiem.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.DaTa
{
    internal class CauHoiDB
    {
        KetNoi ketnoi = new KetNoi();

        public DataTable load_CauHoi()
        {
            string sql = "load_CauHoi";
            return ketnoi.Load_Data(sql);
        }

        public DataTable loadCauhoiLamBai(CauHoi ch)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@mamon";
            name[1] = "@made";
            

            values[0] = ch.MaMThiChoi;
            values[1] = ch.MDThiChoi;
            
            string sql = "loadCauHoiThi_MaDe";
            return ketnoi.Load_Data_search(sql, name, values, parameter);
        }

        public int insert_CauHoi(CauHoi ch)
        {
            int parameter = 8;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@noidung";
            name[1] = "@DA1";
            name[2] = "@DA2";
            name[3] = "@DA3";
            name[4] = "@DA4";
            name[5] = "@DAPANCK";
            name[6] = "@MAMONHOC";
            name[7] = "@MADETHI";
            
            values[0] = ch.Ndung;
            values[1] = ch.Da1;
            values[2] = ch.Da2;
            values[3] = ch.Da3;
            values[4] = ch.Da4;
            values[5] = ch.DaRCheck;
            values[6] = ch.MaMThiChoi;
            values[7] =ch.MDThiChoi;
            string sql = "insert_CauHoi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int update_CauHoi(CauHoi ch)
        {
            int parameter = 9;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@macau";
            name[1] = "@noidung";
            name[2] = "@DA1";
            name[3] = "@DA2";
            name[4] = "@DA3";
            name[5] = "@DA4";
            name[6] = "@DAPANCK";
            name[7] = "@MAMONHOC";
            name[8] = "@MADETHI";

            values[0] = ch.MaChoi;
            values[1] = ch.Ndung;
            values[2] = ch.Da1;
            values[3] = ch.Da2;
            values[4] = ch.Da3;
            values[5] = ch.Da4;
            values[6] = ch.DaRCheck;
            values[7] = ch.MaMThiChoi;
            values[8] = ch.MDThiChoi;
            string sql = "update_CauHoi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int delete_CauHoi(CauHoi ch)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@macau";
            
            values[0] = ch.MaChoi;
            
            string sql = "delete_CauHoi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

    }
}
