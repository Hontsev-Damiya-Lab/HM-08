using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_08_b
{
    public enum Oper
    {
        equal, more, less, add, reduce
    }
    class Expr:ShowElem
    {
        public int STno = -1;
        public int Pno = -1;
        public int num = 0;
        public Oper oper = Oper.equal;

        public string getName()
        {
            if (STno == -1) return "";
            else return STno + "$" + Pno + "$" + oper.ToString() + "$"+ num;
        }
    }
}
