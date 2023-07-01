using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiTracNghiem.Object
{
    internal class MonThi
    {
        private String _mamon;
        private String _tenmon;
        public String Mamon { get { return _mamon; } set { _mamon = value; } }
        public String Tenmon { get { return _tenmon; } set { _tenmon = value; } }
    }
}
