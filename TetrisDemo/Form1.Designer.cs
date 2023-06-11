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
            SettingfToolStripMenuItem = new ToolStripMenuItem();
            SpeedToolStripMenuItem = new ToolStripMenuItem();
            SlowerToolStripMenuItem = new ToolStripMenuItem();
            SlowToolStripMenuItem = new ToolStripMenuItem();
            QuickToolStripMenuItem = new ToolStripMenuItem();
            QuickerToolStripMenuItem = new ToolStripMenuItem();
            QuickestToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            OperatingToolStripMenuItem = new ToolStripMenuItem();
            RankingToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            msg = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBackGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_preView).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // picBackGround
            // 
            picBackGround.BackColor = Color.White;
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
            label1.Size = new Size(57, 12);
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
            t_score.Size = new Size(21, 21);
            t_score.TabIndex = 4;
            t_score.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { SettingfToolStripMenuItem, HelpToolStripMenuItem, RankingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(616, 27);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // SettingfToolStripMenuItem
            // 
            SettingfToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SpeedToolStripMenuItem, toolStripMenuItem1, ExitToolStripMenuItem });
            SettingfToolStripMenuItem.Name = "SettingfToolStripMenuItem";
            SettingfToolStripMenuItem.Size = new Size(68, 21);
            SettingfToolStripMenuItem.Text = "游戏设置";
            // 
            // SpeedToolStripMenuItem
            // 
            SpeedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SlowerToolStripMenuItem, SlowToolStripMenuItem, QuickToolStripMenuItem, QuickerToolStripMenuItem, QuickestToolStripMenuItem });
            SpeedToolStripMenuItem.Name = "SpeedToolStripMenuItem";
            SpeedToolStripMenuItem.Size = new Size(124, 22);
            SpeedToolStripMenuItem.Text = "速度设置";
            // 
            // SlowerToolStripMenuItem
            // 
            SlowerToolStripMenuItem.Checked = true;
            SlowerToolStripMenuItem.CheckOnClick = true;
            SlowerToolStripMenuItem.CheckState = CheckState.Checked;
            SlowerToolStripMenuItem.Name = "SlowerToolStripMenuItem";
            SlowerToolStripMenuItem.Size = new Size(112, 22);
            SlowerToolStripMenuItem.Text = "较慢";
            SlowerToolStripMenuItem.Click += SlowerToolStripMenuItem_Click;
            // 
            // SlowToolStripMenuItem
            // 
            SlowToolStripMenuItem.CheckOnClick = true;
            SlowToolStripMenuItem.Name = "SlowToolStripMenuItem";
            SlowToolStripMenuItem.Size = new Size(112, 22);
            SlowToolStripMenuItem.Text = "慢";
            SlowToolStripMenuItem.Click += SlowToolStripMenuItem_Click;
            // 
            // QuickToolStripMenuItem
            // 
            QuickToolStripMenuItem.CheckOnClick = true;
            QuickToolStripMenuItem.Name = "QuickToolStripMenuItem";
            QuickToolStripMenuItem.Size = new Size(112, 22);
            QuickToolStripMenuItem.Text = "快";
            QuickToolStripMenuItem.Click += QuickToolStripMenuItem_Click;
            // 
            // QuickerToolStripMenuItem
            // 
            QuickerToolStripMenuItem.CheckOnClick = true;
            QuickerToolStripMenuItem.Name = "QuickerToolStripMenuItem";
            QuickerToolStripMenuItem.Size = new Size(112, 22);
            QuickerToolStripMenuItem.Text = "较快";
            QuickerToolStripMenuItem.Click += QuickerToolStripMenuItem_Click;
            // 
            // QuickestToolStripMenuItem
            // 
            QuickestToolStripMenuItem.CheckOnClick = true;
            QuickestToolStripMenuItem.Name = "QuickestToolStripMenuItem";
            QuickestToolStripMenuItem.Size = new Size(112, 22);
            QuickestToolStripMenuItem.Text = "非常快";
            QuickestToolStripMenuItem.Click += QuickestToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(121, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(124, 22);
            ExitToolStripMenuItem.Text = "退出";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem, OperatingToolStripMenuItem });
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new Size(44, 21);
            HelpToolStripMenuItem.Text = "帮助";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(124, 22);
            AboutToolStripMenuItem.Text = "关于";
            AboutToolStripMenuItem.Click += 关于ToolStripMenuItem_Click;
            // 
            // OperatingToolStripMenuItem
            // 
            OperatingToolStripMenuItem.Name = "OperatingToolStripMenuItem";
            OperatingToolStripMenuItem.Size = new Size(124, 22);
            OperatingToolStripMenuItem.Text = "操作说明";
            OperatingToolStripMenuItem.Click += OperatingToolStripMenuItem_Click;
            // 
            // RankingToolStripMenuItem
            // 
            RankingToolStripMenuItem.Name = "RankingToolStripMenuItem";
            RankingToolStripMenuItem.Size = new Size(56, 21);
            RankingToolStripMenuItem.Text = "排行榜";
            RankingToolStripMenuItem.Click += RankingToolStripMenuItem_Click;
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
            msg.Size = new Size(39, 20);
            msg.TabIndex = 7;
            msg.Text = "msg";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(t_score);
            groupBox1.Location = new Point(379, 245);
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
            button1.Location = new Point(379, 363);
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
            button2.Location = new Point(379, 403);
            button2.Name = "button2";
            button2.Size = new Size(217, 32);
            button2.TabIndex = 10;
            button2.TabStop = false;
            button2.Text = "暂停";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(379, 441);
            button4.Name = "button4";
            button4.Size = new Size(217, 31);
            button4.TabIndex = 12;
            button4.TabStop = false;
            button4.Text = "重新开始";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(379, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(217, 50);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "等级";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(98, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(616, 527);
            Controls.Add(groupBox2);
            Controls.Add(button4);
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
            FormClosed += Form1_Closed;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBackGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_preView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.PictureBox pic_preView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label t_score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperatingToolStripMenuItem;

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.ToolStripMenuItem SlowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuickestToolStripMenuItem;

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button4;
        private ToolStripMenuItem RankingToolStripMenuItem;
        private GroupBox groupBox2;
        private Label label2;
    }
}