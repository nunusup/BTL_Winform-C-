using BTL_ThiTracNghiem.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.DaTa
{
    internal class MonThiDB
    {
        KetNoi ketnoi = new KetNoi();

        public DataTable load_monthi()
        {
            string sql = "load_MonThi";
            return ketnoi.Load_Data(sql);
        }

        public DataTable load_monthiexitMade()
        {
            string sql = "load_MonThivsMade";
            return ketnoi.Load_Data(sql);
        }
        public DataTable load_monthiexitMadeRamDom(string mamt, int so)
        {
            string sql = "Randomdethi";
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@mamh";
            name[1] = "@dem";

            values[0] = mamt;
            values[1] = so;
            return ketnoi.Load_Data_search(sql, name, values, parameter);
        }
        public int Made_exitMonThi(string mt)
        {
            string sql = "select count(*) from iddethi, monhoc where iddethi.mamonthi = monhoc.mamon and monhoc.mamon = '" + mt+ "'";
            return ketnoi.rtInteger(sql);
        }

        public string Lay1MD(string mamt)
        {
            string sqlmade = "select iddethi.madethi from iddethi, monhoc where iddethi.mamonthi = monhoc.mamon and monhoc.mamon = '" + mamt + "'";
            
            return ketnoi.LmdobjMT_MD(sqlmade);
        }
        
        public int insert_monthi(MonThi mthi)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAM";
            name[1] = "@TENM";
            
            values[0] = mthi.Mamon;
            values[1] = mthi.Tenmon;
            
            string sql = "Insert_MonThi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int update_monthi(MonThi mthi)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAM";
            name[1] = "@TENM";

            values[0] = mthi.Mamon;
            values[1] = mthi.Tenmon;
            string sql = "Update_MonThi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        public int delete_monthi(MonThi mthi)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAM";
            values[0] = mthi.Mamon;
            string sql = "Delete_MonThi";
            return ketnoi.Execute(sql, name, values, parameter);
        }

        
    }
}
