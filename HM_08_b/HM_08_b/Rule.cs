using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_08_b
{
    class Rule : ShowElem
    {
        public static int NUM = 100;
        public int stilltime = 0;
        public Expr[] Icond = new Expr[NUM];
        public Expr[] Ocond = new Expr[NUM];
        public Expr[] res = new Expr[NUM];

        public string getName()
        {
            if (stilltime == 0) return "--";
            else return "rule (" + stilltime + ")";
        }
    }
}
