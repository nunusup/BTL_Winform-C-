using BTL_ThiTracNghiem.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.DaTa
{
    internal class MaThiDB
    {

        KetNoi ketnoi = new KetNoi();

        public DataTable load_made()
        {
            string sql = "load_DeThi";
            return ketnoi.Load_Data(sql);
        }

        public DataTable load_MadeexecMonthi(string mamt)
        {
            string sql = "load_dethiExecMonThi";
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@mamonTex";
            values[0] = mamt;          
            return ketnoi.Load_Data_search(sql, name, values, parameter);
        }


        public int insert_made(MaThics mtde)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAD";
            name[1] = "@MAM";

            values[0] = mtde.Made;
            values[1] = mtde.MaMont;

            string sql = "Insert_DeThi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int update_made(MaThics mtde)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAD";
            name[1] = "@MAM";

            values[0] = mtde.Made;
            values[1] = mtde.MaMont;

            string sql = "Update_DeThi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int delete_made(MaThics mtde)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAD";

            values[0] = mtde.Made;

            string sql = "Delete_Dethi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        
}
}
