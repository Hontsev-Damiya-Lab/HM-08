using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_08_b
{
    class ST : ShowElem
    {
        public string name = "";
        public static int PNUM = 100;
        public static int RNUM = 100;
        public static int INHENUM = 100;
        public int initmax = 0;
        public int initmin = 0;
        public Prop[] p = new Prop[PNUM];
        public Rule[] r = new Rule[RNUM];
        public int[] inhe = new int[INHENUM];

        public string getName()
        {
            if (name.Length < 1) return "--";
            else return name;
        }
    }
}
