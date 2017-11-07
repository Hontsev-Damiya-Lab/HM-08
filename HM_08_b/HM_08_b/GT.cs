using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_08_b
{
    class GT : ShowElem
    {
        public string name = "";

        public string getName()
        {
            if (name.Length < 1) return "--";
            else return name;
        }
    }
}
