using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace HM_08_b
{
    public partial class Form1 : Form
    {
        Drama drama;
        private BindingList<string> stList1 = new BindingList<string>();
        private BindingList<string> stList2 = new BindingList<string>();
        private BindingList<string> stList3 = new BindingList<string>();
        private BindingList<string> gtList = new BindingList<string>();
        private BindingList<string> iList = new BindingList<string>();
        private BindingList<string> pList1 = new BindingList<string>();
        private BindingList<string> pList2 = new BindingList<string>();
        private BindingList<string> rList = new BindingList<string>();
        private BindingList<string> riList = new BindingList<string>();
        private BindingList<string> roList = new BindingList<string>();
        private BindingList<string> rrList = new BindingList<string>();
        private BindingList<string> operList1 = new BindingList<string> { Oper.equal.ToString(), Oper.less.ToString(), Oper.more.ToString() };
        private BindingList<string> operList2 = new BindingList<string> { Oper.equal.ToString(), Oper.less.ToString(), Oper.more.ToString() };
        private BindingList<string> operList3 = new BindingList<string> { Oper.add.ToString(), Oper.reduce.ToString() };
        private BindingList<string> objectList = new BindingList<string> { "self", "other" };
        private BindingList<string> allpList = new BindingList<string>();
        private BindingList<string> allrList = new BindingList<string>();
        bool filling = false;

        public Form1()
        {
            InitializeComponent();
            drama = new Drama();
        }

        private void loadfile(string fname)
        {
            FileStream file = new FileStream(fname, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file, Encoding.Default);
            drama.loadDrama( read.ReadToEnd() );
            read.Close();
            file.Close();
        }
        private void savefile(string fname)
        {
            if (fname.Length > 0)
            {
                FileStream file = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter fw = new StreamWriter(file, Encoding.Default);
                fw.Write(drama.saveDrama());
                fw.Close();
                file.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new drama
            drama.initDrama();
            textBox1.Text = drama.name;
            updateBasicInfo();
            updateList();
            initList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load drama
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loadfile(openFileDialog1.FileName);
            updateBasicInfo();
            initList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //save drama
            string adviceName = "Drama_" + drama.name;
            saveFileDialog1.FileName = adviceName;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            savefile(saveFileDialog1.FileName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            drama.name = textBox1.Text;
            updateBasicInfo();
        }
        public void updateBasicInfo()
        {
            textBox1.Text = drama.name;
            numericUpDown8.Value = Drama.GTNUM;
            numericUpDown9.Value = Drama.STNUM;
            numericUpDown10.Value = ST.PNUM;
            numericUpDown11.Value = Rule.NUM;
            numericUpDown12.Value = ST.RNUM;
            numericUpDown13.Value = ST.INHENUM;
            label4.Text = drama.getSTNum().ToString();
            label5.Text = drama.getGTNum().ToString();
        }
        public void updateList()
        {
            fillWithArray(ref stList1, drama.st, Drama.STNUM);
            fillWithArray(ref stList2, drama.st, Drama.STNUM);
            fillWithArray(ref stList3, drama.st, Drama.STNUM);
            //fillWithArray(ref iList, drama.i, Drama.STNUM);
            fillWithArray(ref gtList, drama.gt, Drama.GTNUM);
            //fillWithArray(ref pList1, drama.st, Drama.STNUM);
            //fillWithArray(ref pList2, drama.st, Drama.STNUM);
            //fillWithArray(ref rList, drama.st, Drama.STNUM);
            //fillWithArray(ref riList, drama.st, Drama.STNUM);
            //fillWithArray(ref roList, drama.st, Drama.STNUM);
            //fillWithArray(ref rrList, drama.st, Drama.STNUM);
            //fillWithArray(ref allpList, drama.st, Drama.STNUM);
            //fillWithArray(ref objectList, drama.st, Drama.STNUM);
            //fillWithArray(ref allrList, drama.st, Drama.STNUM);
            //initList();
        }
        private void initList()
        {
            listBox1.DataSource = stList1;
            listBox2.DataSource = stList2;
            listBox3.DataSource = iList;
            listBox4.DataSource = gtList;
            listBox5.DataSource = pList1;
            listBox6.DataSource = rList;
            listBox7.DataSource = riList;
            listBox8.DataSource = roList;
            listBox9.DataSource = rrList;
            comboBox1.DataSource = stList3;
            comboBox3.DataSource = operList1;
            comboBox4.DataSource = operList2;
            comboBox6.DataSource = operList3;
            comboBox2.DataSource = pList2;
            comboBox5.DataSource = allpList;
            comboBox7.DataSource = objectList;
            comboBox8.DataSource = allrList;
        }
        private void fillWithArray(ref BindingList<string> list, ShowElem[] array, int length)
        {
            filling = true;
            bool isnew = false;
            if (list == null || list.Count <= 0)
            {
                isnew = true;
                list = new BindingList<string>();
            }
            for (int i = 0; i < length; i++)
            {
                string tmpName = array[i].getName();
                string[] namePart = tmpName.Split('$');
                string realName = "";
                //将名字中的序号转化成对应元素的名称
                int num1 = 0;
                int num2 = 0;
                for (int ii = 0; ii < namePart.Length; ii++)
                {
                    if (int.TryParse(namePart[ii], out num1) == true)
                    {
                        if (ii == 0)
                        {
                            realName += drama.st[num1].name + " ";
                            num2 = num1;
                        }
                        else if (ii == 1)
                        {
                            realName += drama.st[num2].p[num1].name + " ";
                        }
                        else
                        {
                            realName += namePart[ii] + " ";
                        }
                    }
                    else
                    {
                        realName += namePart[ii] + " ";
                    }
                }
                if (isnew) list.Add(realName);
                else
                {
                    list[i] = realName;
                    //list.Insert(i,realName);
                    //list.RemoveAt(i);
                }
            }
            filling = false;
        }
        public void updateSTInfo(int no)
        {
            if (no < 0 || no >= Drama.STNUM) return;
            textBox4.Text = drama.st[no].getName();
            //根据继承实体列表逐一找其名称字符串用于显示
            ST[] tmpST = new ST[ST.INHENUM];
            for (int i = 0; i < ST.INHENUM; i++)
            {
                tmpST[i] = new ST();
                if (drama.st[no].inhe[i] < 0) tmpST[i].name = "";
                else tmpST[i].name = drama.st[drama.st[no].inhe[i]].name;
            }
            fillWithArray(ref iList, tmpST, ST.INHENUM);
            tmpST = new ST[Drama.STNUM];
            for (int i = 0; i < no; i++)
            {
                tmpST[i] = new ST();
                tmpST[i].name = drama.st[i].name;
            }
            tmpST[no] = new ST();
            tmpST[no].name = "--";
            for (int i = no + 1; i < Drama.STNUM; i++)
            {
                tmpST[i] = new ST();
                tmpST[i].name = drama.st[i].name;
            }
            fillWithArray(ref stList1, tmpST, Drama.STNUM);
            fillWithArray(ref pList1, drama.st[no].p, ST.PNUM);
            fillWithArray(ref rList, drama.st[no].r, ST.RNUM);
            initList();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (filling) return;
            int no = listBox1.SelectedIndex;
            drama.st[no].initmin = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (filling) return;
            int no = listBox1.SelectedIndex;
            drama.st[no].initmax = (int)numericUpDown3.Value;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (filling) return;
            Drama.GTNUM = (int)numericUpDown8.Value;
            updateBasicInfo();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (filling) return;
            Drama.STNUM = (int)numericUpDown9.Value;
            updateBasicInfo();
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            if (filling) return;
            ST.PNUM = (int)numericUpDown10.Value;
            updateBasicInfo();
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            if (filling) return;
            ST.INHENUM = (int)numericUpDown13.Value;
            updateBasicInfo();
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            if (filling) return;
            ST.RNUM = (int)numericUpDown12.Value;
            updateBasicInfo();
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if (filling) return;
            Rule.NUM = (int)numericUpDown11.Value;
            updateBasicInfo();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int no = listBox2.SelectedIndex;
            drama.st[no].name = textBox4.Text;
            updateSTInfo(no);
            updateList();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int no = listBox1.SelectedIndex;
            numericUpDown1.Value = drama.st[no].initmin;
            numericUpDown3.Value = drama.st[no].initmax;
        }

        private void listBox4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            int no = listBox2.SelectedIndex;
            updateSTInfo(no);
        }

        private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
            int no = listBox3.SelectedIndex;
            int stno = listBox2.SelectedIndex;
            int inheno = drama.st[stno].inhe[no];
            if (inheno >= 0)
            {
                comboBox1.SelectedIndex = inheno;
            }
        }

        private void listBox5_MouseClick(object sender, MouseEventArgs e)
        {
            int stno = listBox2.SelectedIndex;
            int no = listBox5.SelectedIndex;
            int pstno = drama.st[stno].p[no].STno;
            textBox5.Text = drama.st[stno].p[no].name;
            numericUpDown1.Value = drama.st[stno].p[no].num;
            if (pstno >= 0)
            {
                textBox6.Text = drama.st[pstno].name;
            }
            else
            {
                textBox6.Text = "无";
            }
        }

        private void listBox6_MouseClick(object sender, MouseEventArgs e)
        {
            int stno = listBox2.SelectedIndex;
            int no = listBox6.SelectedIndex;

        }

        private void listBox7_MouseClick(object sender, MouseEventArgs e)
        {
            int no = listBox7.SelectedIndex;
        }

        private void listBox8_MouseClick(object sender, MouseEventArgs e)
        {
            int no = listBox8.SelectedIndex;
        }

        private void listBox9_MouseClick(object sender, MouseEventArgs e)
        {
            int no = listBox9.SelectedIndex;
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int stno = listBox2.SelectedIndex;
            int inheno = listBox3.SelectedIndex;
            int no = comboBox1.SelectedIndex;
            drama.st[stno].inhe[inheno] = no;
            updateSTInfo(stno);
            //fillWithArray(iList, drama.st[stno].inhe, ST.INHENUM);

        }
    }
}
