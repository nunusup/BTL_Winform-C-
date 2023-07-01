using BTL_ThiTracNghiem.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.DaTa
{
    internal class PhieuDiemDB
    {
        KetNoi ketnoi = new KetNoi();

        public DataTable load_PhieuDiem()
        {
            string sql = "load_Phieu";
            return ketnoi.Load_Data(sql);
        }

        public int insert_PhieuDiem(PhieuDiem pd)
        {
            int parameter = 7;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@maMt";
            name[1] = "@maDt";
            name[2] = "@mats";
            name[3] = "@tscau";
            name[4] = "@sdung";
            name[5] = "@ssai";
            name[6] = "@tdiem";
            

            
            values[0] = pd.MaMonPhieu;
            values[1] = pd.MaDePhieu;
            values[2] = pd.MaSinhVienThi;
            values[3] = pd.Tongcau;
            values[4] = pd.Caudung;
            values[5] = pd.Causai;
            values[6] = pd.Tongdiem;
            string sql = "insert_Phieu";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int delete_PhieuDiem(PhieuDiem pd)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MaP";

            values[0] = pd.MaDePhieu;

            string sql = "delete_Phieu";
            return ketnoi.Execute(sql, name, values, parameter);
        }
    }
}
