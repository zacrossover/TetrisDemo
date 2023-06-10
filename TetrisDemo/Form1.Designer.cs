namespace TetrisDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picBackGround = new PictureBox();
            pic_preView = new PictureBox();
            label1 = new Label();
            t_score = new Label();
            menuStrip1 = new MenuStrip();
            游戏设置ToolStripMenuItem = new ToolStripMenuItem();
            速度设置ToolStripMenuItem = new ToolStripMenuItem();
            较慢ToolStripMenuItem = new ToolStripMenuItem();
            慢ToolStripMenuItem = new ToolStripMenuItem();
            快ToolStripMenuItem = new ToolStripMenuItem();
            较快ToolStripMenuItem = new ToolStripMenuItem();
            非常快ToolStripMenuItem = new ToolStripMenuItem();
            背景颜色设置ToolStripMenuItem = new ToolStripMenuItem();
            方块颜色设置ToolStripMenuItem = new ToolStripMenuItem();
            恢复默认设置ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            控制ToolStripMenuItem = new ToolStripMenuItem();
            开始ToolStripMenuItem = new ToolStripMenuItem();
            暂停ToolStripMenuItem1 = new ToolStripMenuItem();
            结束ToolStripMenuItem = new ToolStripMenuItem();
            重新开始ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            操作说明ToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            msg = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            排行榜ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picBackGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_preView).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // picBackGround
            // 
            picBackGround.BackColor = Color.Gainsboro;
            picBackGround.BorderStyle = BorderStyle.Fixed3D;
            picBackGround.Location = new Point(13, 31);
            picBackGround.Margin = new Padding(4);
            picBackGround.Name = "picBackGround";
            picBackGround.Size = new Size(300, 450);
            picBackGround.TabIndex = 0;
            picBackGround.TabStop = false;
            // 
            // pic_preView
            // 
            pic_preView.BackColor = Color.Gainsboro;
            pic_preView.BorderStyle = BorderStyle.Fixed3D;
            pic_preView.Location = new Point(379, 61);
            pic_preView.Margin = new Padding(4);
            pic_preView.Name = "pic_preView";
            pic_preView.Size = new Size(217, 177);
            pic_preView.TabIndex = 2;
            pic_preView.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(379, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 3;
            label1.Text = "下一个：";
            // 
            // t_score
            // 
            t_score.AutoSize = true;
            t_score.Font = new Font("楷体", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            t_score.ForeColor = Color.Green;
            t_score.Location = new Point(100, 19);
            t_score.Margin = new Padding(4, 0, 4, 0);
            t_score.Name = "t_score";
            t_score.Size = new Size(31, 33);
            t_score.TabIndex = 4;
            t_score.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 游戏设置ToolStripMenuItem, 控制ToolStripMenuItem, 帮助ToolStripMenuItem, 排行榜ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(616, 34);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // 游戏设置ToolStripMenuItem
            // 
            游戏设置ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 速度设置ToolStripMenuItem, 背景颜色设置ToolStripMenuItem, 方块颜色设置ToolStripMenuItem, 恢复默认设置ToolStripMenuItem, toolStripMenuItem1, 退出ToolStripMenuItem });
            游戏设置ToolStripMenuItem.Name = "游戏设置ToolStripMenuItem";
            游戏设置ToolStripMenuItem.Size = new Size(98, 28);
            游戏设置ToolStripMenuItem.Text = "游戏设置";
            // 
            // 速度设置ToolStripMenuItem
            // 
            速度设置ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 较慢ToolStripMenuItem, 慢ToolStripMenuItem, 快ToolStripMenuItem, 较快ToolStripMenuItem, 非常快ToolStripMenuItem });
            速度设置ToolStripMenuItem.Name = "速度设置ToolStripMenuItem";
            速度设置ToolStripMenuItem.Size = new Size(270, 34);
            速度设置ToolStripMenuItem.Text = "速度设置";
            // 
            // 较慢ToolStripMenuItem
            // 
            较慢ToolStripMenuItem.Checked = true;
            较慢ToolStripMenuItem.CheckOnClick = true;
            较慢ToolStripMenuItem.CheckState = CheckState.Checked;
            较慢ToolStripMenuItem.Name = "较慢ToolStripMenuItem";
            较慢ToolStripMenuItem.Size = new Size(164, 34);
            较慢ToolStripMenuItem.Text = "较慢";
            较慢ToolStripMenuItem.Click += 较慢ToolStripMenuItem_Click;
            // 
            // 慢ToolStripMenuItem
            // 
            慢ToolStripMenuItem.CheckOnClick = true;
            慢ToolStripMenuItem.Name = "慢ToolStripMenuItem";
            慢ToolStripMenuItem.Size = new Size(164, 34);
            慢ToolStripMenuItem.Text = "慢";
            慢ToolStripMenuItem.Click += 慢ToolStripMenuItem_Click;
            // 
            // 快ToolStripMenuItem
            // 
            快ToolStripMenuItem.CheckOnClick = true;
            快ToolStripMenuItem.Name = "快ToolStripMenuItem";
            快ToolStripMenuItem.Size = new Size(164, 34);
            快ToolStripMenuItem.Text = "快";
            快ToolStripMenuItem.Click += 快ToolStripMenuItem_Click;
            // 
            // 较快ToolStripMenuItem
            // 
            较快ToolStripMenuItem.CheckOnClick = true;
            较快ToolStripMenuItem.Name = "较快ToolStripMenuItem";
            较快ToolStripMenuItem.Size = new Size(164, 34);
            较快ToolStripMenuItem.Text = "较快";
            较快ToolStripMenuItem.Click += 较快ToolStripMenuItem_Click;
            // 
            // 非常快ToolStripMenuItem
            // 
            非常快ToolStripMenuItem.CheckOnClick = true;
            非常快ToolStripMenuItem.Name = "非常快ToolStripMenuItem";
            非常快ToolStripMenuItem.Size = new Size(164, 34);
            非常快ToolStripMenuItem.Text = "非常快";
            非常快ToolStripMenuItem.Click += 非常快ToolStripMenuItem_Click;
            // 
            // 背景颜色设置ToolStripMenuItem
            // 
            背景颜色设置ToolStripMenuItem.Name = "背景颜色设置ToolStripMenuItem";
            背景颜色设置ToolStripMenuItem.Size = new Size(270, 34);
            背景颜色设置ToolStripMenuItem.Text = "背景颜色设置";
            背景颜色设置ToolStripMenuItem.Click += 背景颜色设置ToolStripMenuItem_Click;
            // 
            // 方块颜色设置ToolStripMenuItem
            // 
            方块颜色设置ToolStripMenuItem.Name = "方块颜色设置ToolStripMenuItem";
            方块颜色设置ToolStripMenuItem.Size = new Size(270, 34);
            方块颜色设置ToolStripMenuItem.Text = "方块颜色设置";
            方块颜色设置ToolStripMenuItem.Click += 方块颜色设置ToolStripMenuItem_Click;
            // 
            // 恢复默认设置ToolStripMenuItem
            // 
            恢复默认设置ToolStripMenuItem.Name = "恢复默认设置ToolStripMenuItem";
            恢复默认设置ToolStripMenuItem.Size = new Size(270, 34);
            恢复默认设置ToolStripMenuItem.Text = "恢复默认设置";
            恢复默认设置ToolStripMenuItem.Click += 恢复默认设置ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(267, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(270, 34);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 控制ToolStripMenuItem
            // 
            控制ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 开始ToolStripMenuItem, 暂停ToolStripMenuItem1, 结束ToolStripMenuItem, 重新开始ToolStripMenuItem });
            控制ToolStripMenuItem.Name = "控制ToolStripMenuItem";
            控制ToolStripMenuItem.Size = new Size(62, 28);
            控制ToolStripMenuItem.Text = "控制";
            控制ToolStripMenuItem.Visible = false;
            // 
            // 开始ToolStripMenuItem
            // 
            开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            开始ToolStripMenuItem.Size = new Size(270, 34);
            开始ToolStripMenuItem.Text = "开始";
            开始ToolStripMenuItem.Click += 开始ToolStripMenuItem1_Click;
            // 
            // 暂停ToolStripMenuItem1
            // 
            暂停ToolStripMenuItem1.Enabled = false;
            暂停ToolStripMenuItem1.Name = "暂停ToolStripMenuItem1";
            暂停ToolStripMenuItem1.Size = new Size(270, 34);
            暂停ToolStripMenuItem1.Text = "暂停";
            暂停ToolStripMenuItem1.Click += 暂停ToolStripMenuItem1_Click;
            // 
            // 结束ToolStripMenuItem
            // 
            结束ToolStripMenuItem.Enabled = false;
            结束ToolStripMenuItem.Name = "结束ToolStripMenuItem";
            结束ToolStripMenuItem.Size = new Size(270, 34);
            结束ToolStripMenuItem.Text = "结束";
            结束ToolStripMenuItem.Click += 结束ToolStripMenuItem_Click;
            // 
            // 重新开始ToolStripMenuItem
            // 
            重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
            重新开始ToolStripMenuItem.Size = new Size(270, 34);
            重新开始ToolStripMenuItem.Text = "重新开始";
            重新开始ToolStripMenuItem.Click += 重新开始ToolStripMenuItem_Click;
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 关于ToolStripMenuItem, 操作说明ToolStripMenuItem });
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(62, 28);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(270, 34);
            关于ToolStripMenuItem.Text = "关于";
            关于ToolStripMenuItem.Click += 关于ToolStripMenuItem_Click;
            // 
            // 操作说明ToolStripMenuItem
            // 
            操作说明ToolStripMenuItem.Name = "操作说明ToolStripMenuItem";
            操作说明ToolStripMenuItem.Size = new Size(270, 34);
            操作说明ToolStripMenuItem.Text = "操作说明";
            操作说明ToolStripMenuItem.Click += 操作说明ToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // msg
            // 
            msg.AutoSize = true;
            msg.BackColor = Color.White;
            msg.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point);
            msg.ForeColor = Color.FromArgb(192, 0, 0);
            msg.Location = new Point(147, 245);
            msg.Margin = new Padding(4, 0, 4, 0);
            msg.Name = "msg";
            msg.Size = new Size(58, 30);
            msg.TabIndex = 7;
            msg.Text = "msg";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(t_score);
            groupBox1.Location = new Point(379, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(217, 50);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "分数";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(379, 332);
            button1.Name = "button1";
            button1.Size = new Size(217, 34);
            button1.TabIndex = 9;
            button1.TabStop = false;
            button1.Text = "开始";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(379, 385);
            button2.Name = "button2";
            button2.Size = new Size(217, 32);
            button2.TabIndex = 10;
            button2.TabStop = false;
            button2.Text = "暂停";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(379, 435);
            button3.Name = "button3";
            button3.Size = new Size(102, 37);
            button3.TabIndex = 11;
            button3.TabStop = false;
            button3.Text = "结束";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(498, 435);
            button4.Name = "button4";
            button4.Size = new Size(98, 37);
            button4.TabIndex = 12;
            button4.TabStop = false;
            button4.Text = "重新开始";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // 排行榜ToolStripMenuItem
            // 
            排行榜ToolStripMenuItem.Name = "排行榜ToolStripMenuItem";
            排行榜ToolStripMenuItem.Size = new Size(80, 28);
            排行榜ToolStripMenuItem.Text = "排行榜";
            排行榜ToolStripMenuItem.Click += 排行榜ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(616, 701);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pic_preView);
            Controls.Add(menuStrip1);
            Controls.Add(picBackGround);
            Controls.Add(msg);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "俄罗斯方块";
            Activated += Form1_Activated;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBackGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_preView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.PictureBox pic_preView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label t_score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 速度设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景颜色设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 结束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.ToolStripMenuItem 方块颜色设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 较慢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 慢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 较快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 非常快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复默认设置ToolStripMenuItem;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem 排行榜ToolStripMenuItem;
    }
}