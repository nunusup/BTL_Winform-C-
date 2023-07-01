using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.Object
{
    internal class PhieuDiem
    {
        string maphieu;
        string mamonPhieu;
        string madephieu;
        string masv;
        int tongcau;
        int caudung;
        int causai;
        float tongdiem;
        public string Maphieu { get { return maphieu; } set { maphieu= value ; } }
        public string MaMonPhieu { get { return mamonPhieu; } set { mamonPhieu = value; } }
        public string MaDePhieu { get { return madephieu; } set { madephieu = value; } }
        public string MaSinhVienThi { get { return masv; } set { masv = value; } }
        public int Tongcau { get { return tongcau; } set {tongcau=value; } }
        public int Caudung { get{  return caudung; } set { caudung=value; } }
        public int Causai { get { return causai; } set { causai = value; } }
        public float Tongdiem { get { return tongdiem; } set {tongdiem=value; } }
    }
}
