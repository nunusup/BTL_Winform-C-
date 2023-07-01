using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.Object
{
    internal class CauHoi
    {
        public const string _FORMAT_QUESTION = "QUESTION {0}/{1}:\n {2}";
        string machoi;
        string ndung;
        string da1;
        string da2;
        string da3;
        string da4;
        int daRCheck;
        string maMThiChoi;
        string maDThiChoi;
        public string MaChoi { get { return machoi; } set { machoi = value; } }
        public string Ndung { get { return ndung; } set { ndung = value; } }
        public string Da1 { get { return da1; } set { da1 = value; } }
        public string Da2 { get { return da2; } set { da2 = value; } }
        public string Da3 { get { return da3; } set { da3 = value; } }
        public string Da4 { get { return da4; } set { da4 = value; } }
        public int DaRCheck { get { return daRCheck; } set {daRCheck=value; } }
        public string MaMThiChoi { get { return maMThiChoi; } set {maMThiChoi = value; } }
        public string MDThiChoi { get { return maDThiChoi; } set {maDThiChoi=value; } }

    }
}
