using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_08_b
{
    class Drama
    {
        public string name;
        public static int STNUM = 100;
        public static int GTNUM = 100;
        public ST[] st = new ST[STNUM];
        public GT[] gt = new GT[GTNUM];

        public string saveDrama()
        {
            string res = "";
            res += name + "$";
            res += STNUM + "$";
            res += ST.PNUM + "$";
            res += ST.INHENUM + "$";
            res += ST.RNUM + "$";
            res += Rule.NUM + "$";
            res += GTNUM + "$";
            for (int i = 0; i < STNUM; i++)
            {
                res += st[i].name + "$";
                res += st[i].initmin + "$";
                res += st[i].initmax + "$";
                for (int j = 0; j < ST.PNUM; j++)
                {
                    res += st[i].p[j].name + "$";
                    res += st[i].p[j].num + "$";
                    res += st[i].p[j].STno + "$";
                }
                for (int j = 0; j < ST.RNUM; j++)
                {
                    res += st[i].r[j].stilltime + "$";
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        res += st[i].r[j].Icond[k].STno + "$";
                        res += st[i].r[j].Icond[k].Pno + "$";
                        res += st[i].r[j].Icond[k].oper.ToString() + "$";
                        res += st[i].r[j].Icond[k].num + "$";
                    }
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        res += st[i].r[j].Ocond[k].STno + "$";
                        res += st[i].r[j].Ocond[k].Pno + "$";
                        res += st[i].r[j].Ocond[k].oper.ToString() + "$";
                        res += st[i].r[j].Ocond[k].num + "$";
                    }
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        res += st[i].r[j].res[k].STno + "$";
                        res += st[i].r[j].res[k].Pno + "$";
                        res += st[i].r[j].res[k].oper.ToString() + "$";
                        res += st[i].r[j].res[k].num + "$";
                    }
                }
            }
            return res;
        }
        public void loadDrama(string resStr)
        {
            string[] res = resStr.Split('$');
            name = res[0];
            STNUM = Int32.Parse(res[1]);
            ST.PNUM = Int32.Parse(res[2]);
            ST.INHENUM = Int32.Parse(res[3]);
            ST.RNUM = Int32.Parse(res[4]);
            Rule.NUM = Int32.Parse(res[5]);
            GTNUM = Int32.Parse(res[6]);
            int n = 7;
            for (int i = 0; i < STNUM; i++)
            {
                st[i] = new ST();
                st[i].name = res[n++];
                st[i].initmin = Int32.Parse(res[n++]);
                st[i].initmax = Int32.Parse(res[n++]);
                for (int j = 0; j < ST.PNUM; j++)
                {
                    st[i].p[j] = new Prop();
                    st[i].p[j].name = res[n++];
                    st[i].p[j].num = Int32.Parse(res[n++]);
                    st[i].p[j].STno = Int32.Parse(res[n++]);
                }
                for (int j = 0; j < ST.RNUM; j++)
                {
                    st[i].r[j] = new Rule();
                    st[i].r[j].stilltime = Int32.Parse(res[n++]);
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        st[i].r[j].Icond[k] = new Expr();
                        st[i].r[j].Icond[k].STno = Int32.Parse(res[n++]);
                        st[i].r[j].Icond[k].Pno = Int32.Parse(res[n++]);
                        st[i].r[j].Icond[k].oper = (Oper)Enum.Parse(typeof(Oper),res[n++]);
                        st[i].r[j].Icond[k].num = Int32.Parse(res[n++]);
                    }
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        st[i].r[j].Ocond[k] = new Expr();
                        st[i].r[j].Ocond[k].STno = Int32.Parse(res[n++]);
                        st[i].r[j].Ocond[k].Pno = Int32.Parse(res[n++]);
                        st[i].r[j].Ocond[k].oper = (Oper)Enum.Parse(typeof(Oper), res[n++]);
                        st[i].r[j].Ocond[k].num = Int32.Parse(res[n++]);
                    }
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        st[i].r[j].res[k] = new Expr();
                        st[i].r[j].res[k].STno = Int32.Parse(res[n++]);
                        st[i].r[j].res[k].Pno = Int32.Parse(res[n++]);
                        st[i].r[j].res[k].oper = (Oper)Enum.Parse(typeof(Oper), res[n++]);
                        st[i].r[j].res[k].num = Int32.Parse(res[n++]);
                    }
                }
            }
        }
        public void initDrama()
        {
            this.name = "newDrama";
            STNUM = 10;
            ST.PNUM = 10;
            ST.INHENUM = 10;
            ST.RNUM = 10;
            Rule.NUM = 10;
            GTNUM = 10;
            //init 
            for (int i = 0; i < STNUM; i++)
            {
                st[i] = new ST();
                st[i].name = "";
                st[i].initmin = 0;
                st[i].initmax = 0;
                for (int j = 0; j < ST.PNUM; j++)
                {
                    st[i].p[j] = new Prop();
                    st[i].p[j].name = "";
                    st[i].p[j].num = 0;
                    st[i].p[j].STno = -1;
                }
                for (int j = 0; j < ST.INHENUM; j++)
                {
                    st[i].inhe[j] = -1;
                }
                for (int j = 0; j < ST.RNUM; j++)
                {
                    st[i].r[j] = new Rule();
                    st[i].r[j].stilltime = 0;
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        st[i].r[j].Icond[k] = new Expr();
                        st[i].r[j].Icond[k].num = 0;
                        st[i].r[j].Icond[k].oper = Oper.equal;
                        st[i].r[j].Icond[k].Pno = -1;
                        st[i].r[j].Icond[k].STno = -1;
                    }
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        st[i].r[j].Ocond[k] = new Expr();
                        st[i].r[j].Ocond[k].num = 0;
                        st[i].r[j].Ocond[k].oper = Oper.equal;
                        st[i].r[j].Ocond[k].Pno = -1;
                        st[i].r[j].Ocond[k].STno = -1;
                    }
                    for (int k = 0; k < Rule.NUM; k++)
                    {
                        st[i].r[j].res[k] = new Expr();
                        st[i].r[j].res[k].num = 0;
                        st[i].r[j].res[k].oper = Oper.equal;
                        st[i].r[j].res[k].Pno = -1;
                        st[i].r[j].res[k].STno = -1;
                    }
                }
            }
            for (int i = 0; i < GTNUM; i++)
            {
                gt[i] = new GT();
                gt[i].name = "";
            }
        }
        public void addST()
        {
            
        }
        public void deleteST(int no)
        {

        }
        public void addGT()
        {
            
        }
        public void deleteGT(int no)
        {

        }
        public int getSTNum()
        {
            int n = 0;
            for (int i = 0; i < STNUM; i++)
            {
                if (st[i] != null && st[i].name.Length > 0) n++;
            }
            return n;
        }
        public int getGTNum()
        {
            int n = 0;
            for (int i = 0; i < GTNUM; i++)
            {
                if (gt[i] != null && gt[i].name.Length > 0) n++;
            }
            return n;
        }
    }
}
