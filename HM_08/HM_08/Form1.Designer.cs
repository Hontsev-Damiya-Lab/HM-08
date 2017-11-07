namespace HM_08
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_main = new System.Windows.Forms.TextBox();
            this.tb_zt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_speed = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_seed = new System.Windows.Forms.TextBox();
            this.tb_drama = new System.Windows.Forms.TextBox();
            this.tb_gt = new System.Windows.Forms.ListBox();
            this.tb_st = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "世界监视器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "个体";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "实体";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "状态";
            // 
            // tb_main
            // 
            this.tb_main.Location = new System.Drawing.Point(4, 24);
            this.tb_main.Multiline = true;
            this.tb_main.Name = "tb_main";
            this.tb_main.ReadOnly = true;
            this.tb_main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_main.Size = new System.Drawing.Size(147, 226);
            this.tb_main.TabIndex = 4;
            // 
            // tb_zt
            // 
            this.tb_zt.Location = new System.Drawing.Point(161, 207);
            this.tb_zt.Multiline = true;
            this.tb_zt.Name = "tb_zt";
            this.tb_zt.ReadOnly = true;
            this.tb_zt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_zt.Size = new System.Drawing.Size(213, 119);
            this.tb_zt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "种子：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "剧本：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "速度";
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(37, 258);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(60, 21);
            this.tb_speed.TabIndex = 12;
            this.tb_speed.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "||";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "加载";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "加载";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_seed
            // 
            this.tb_seed.Location = new System.Drawing.Point(387, 169);
            this.tb_seed.Name = "tb_seed";
            this.tb_seed.ReadOnly = true;
            this.tb_seed.Size = new System.Drawing.Size(118, 21);
            this.tb_seed.TabIndex = 16;
            this.tb_seed.Text = "无";
            // 
            // tb_drama
            // 
            this.tb_drama.Location = new System.Drawing.Point(387, 92);
            this.tb_drama.Name = "tb_drama";
            this.tb_drama.ReadOnly = true;
            this.tb_drama.Size = new System.Drawing.Size(118, 21);
            this.tb_drama.TabIndex = 17;
            this.tb_drama.Text = "无";
            // 
            // tb_gt
            // 
            this.tb_gt.FormattingEnabled = true;
            this.tb_gt.ItemHeight = 12;
            this.tb_gt.Location = new System.Drawing.Point(158, 25);
            this.tb_gt.Name = "tb_gt";
            this.tb_gt.ScrollAlwaysVisible = true;
            this.tb_gt.Size = new System.Drawing.Size(105, 148);
            this.tb_gt.TabIndex = 18;
            // 
            // tb_st
            // 
            this.tb_st.FormattingEnabled = true;
            this.tb_st.ItemHeight = 12;
            this.tb_st.Location = new System.Drawing.Point(269, 24);
            this.tb_st.Name = "tb_st";
            this.tb_st.ScrollAlwaysVisible = true;
            this.tb_st.Size = new System.Drawing.Size(105, 148);
            this.tb_st.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(81, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "保存";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "时刻";
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(37, 284);
            this.tb_time.Name = "tb_time";
            this.tb_time.ReadOnly = true;
            this.tb_time.Size = new System.Drawing.Size(60, 21);
            this.tb_time.TabIndex = 22;
            this.tb_time.Text = "0";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 303);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "加载";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 331);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tb_st);
            this.Controls.Add(this.tb_gt);
            this.Controls.Add(this.tb_drama);
            this.Controls.Add(this.tb_seed);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_speed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_zt);
            this.Controls.Add(this.tb_main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HM_08_世界生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_main;
        private System.Windows.Forms.TextBox tb_zt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_seed;
        private System.Windows.Forms.TextBox tb_drama;
        private System.Windows.Forms.ListBox tb_gt;
        private System.Windows.Forms.ListBox tb_st;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Button button6;
    }
}

