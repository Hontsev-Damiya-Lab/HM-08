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

namespace HM_08
{
    public partial class Form1 : Form
    {
        private int state = 0;
        private World world;
        private Translator translator;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            world = new World();
            translator = new Translator();
            print("初始化完成");
        }

        //输出一行,默认到主屏幕
        private void print(string str ,TextBox place = null)
        {
            if (str.Length < 1) return;
            if (place == null) place = tb_main;
            place.Text = place.Text + str + "\r\n";
            place.Select(place.TextLength, 0);
            place.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //加载种子
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //加载剧本
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //世界运转
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //世界暂停
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //世界保存
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //世界加载
        }
    }
}
