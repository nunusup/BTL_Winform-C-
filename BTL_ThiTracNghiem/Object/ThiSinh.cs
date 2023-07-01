using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.Object
{
    public class ThiSinh
    {
        private string _masv;
        private string _tensv;
        private string _gtinhsv;
        private DateTime _nsinhsv;
        private String _nsinhsvString;
        private string _lopsv;
        public string Masv { get { return _masv; } set { _masv = value; } }

        public string Tensv { get { return _tensv; } set { _tensv = value; } }

        public string Gtinhsv { get { return _gtinhsv; } set { _gtinhsv = value; } }
        public DateTime Nsinhsv { get { return _nsinhsv; } set { _nsinhsv = value; } }
        public String NsinhsvString { get { return _nsinhsvString; } set { _nsinhsvString = value; } }
        public string Lopsv { get { return _lopsv; } set { _lopsv = value; } }


    }
}
