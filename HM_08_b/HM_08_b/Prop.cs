using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_08_b
{
    class Prop : ShowElem
    {
        public string name = "";
        public int num = 0;
        public int STno = -1;

        public string getName()
        {
            if (name.Length<1) return "--";
            else return name;
        }
    }
}
