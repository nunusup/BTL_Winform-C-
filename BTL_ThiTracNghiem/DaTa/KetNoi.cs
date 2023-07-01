using BTL_ThiTracNghiem.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.DaTa
{
    public class KetNoi
    {
        SqlConnection cnt = new SqlConnection(@"Data Source=LAPTOP-ETMJ2PC6\SQLEXPRESS;Initial Catalog=qlyThiTracNghiem;Integrated Security=True");
        public KetNoi()
            {
                if (cnt.State == ConnectionState.Closed)
                {
                cnt.Open();
                }
             }
        public int rtInteger(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnt);
            int ValuesInteger = int.Parse(cmd.ExecuteScalar().ToString());
            return ValuesInteger;
        }
        public string rtString(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnt);
            string ValuesInteger = cmd.ExecuteScalar().ToString();
            return ValuesInteger;
        }
        public string ReturnString_Proc(string sql, string[] name, object[] values, int parameter)
        {
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
            }
            string v = (string)cmd.ExecuteScalar().ToString();
            
            return v;
        }


        public string LmdobjMT_MD(string mtmd)
        {
            SqlCommand cmdmamd = new SqlCommand(mtmd, cnt);
            string made=cmdmamd.ExecuteScalar().ToString();
            return made;
        }

        public ThiSinh rtobjTS(string ma, string ten,string gtinh, string nsinh,string lop)
        {
            SqlCommand cmdma = new SqlCommand(ma, cnt);
            SqlCommand cmdten = new SqlCommand(ten, cnt);
            SqlCommand cmdgtinh = new SqlCommand(gtinh, cnt);
            SqlCommand cmdnsinh = new SqlCommand(nsinh.ToString(), cnt);
            SqlCommand cmdlop = new SqlCommand(lop, cnt);
            ThiSinh thiSinh= new ThiSinh();
            string mats=cmdma.ExecuteScalar().ToString();
            string tents = cmdten.ExecuteScalar().ToString();
            string gtts = cmdgtinh.ExecuteScalar().ToString();
            string namsts = cmdnsinh.ExecuteScalar().ToString();
            string lopts = cmdlop.ExecuteScalar().ToString();
            thiSinh.Masv= mats;
            thiSinh.Tensv= tents;
            thiSinh.Gtinhsv= gtts;
            thiSinh.NsinhsvString= namsts;
            thiSinh.Lopsv = lopts;
            return thiSinh;  
        }
        public DataTable Load_Data(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable Load_DataNotProc(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable Load_Data_search(string sql, string[] name, object[] values, int parameter)
        {
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int Execute(string sql, string[] name, object[] values, int parameter)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cnt);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameter; i++)
                {
                    cmd.Parameters.AddWithValue(name[i], values[i]);
                }
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
        }


    }
}
