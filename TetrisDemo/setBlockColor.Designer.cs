namespace TetrisDemo
{
    partial class setBlockColor
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label2 = new Label();
            pic_preView = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            p_foreColor = new PictureBox();
            p_backColor = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_preView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_foreColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_backColor).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(16, 64);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 1;
            label1.Text = "所有的方块配色方案：";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(154, 64);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 120);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(292, 64);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 120);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(429, 64);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 120);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(16, 218);
            pictureBox5.Margin = new Padding(4, 4, 4, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(116, 120);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(154, 218);
            pictureBox6.Margin = new Padding(4, 4, 4, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(116, 120);
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Location = new Point(292, 218);
            pictureBox7.Margin = new Padding(4, 4, 4, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(116, 120);
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 385);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 2;
            label2.Text = "正在编辑的方块预览：";
            // 
            // pic_preView
            // 
            pic_preView.BorderStyle = BorderStyle.FixedSingle;
            pic_preView.Location = new Point(16, 422);
            pic_preView.Margin = new Padding(4, 4, 4, 4);
            pic_preView.Name = "pic_preView";
            pic_preView.Size = new Size(164, 176);
            pic_preView.TabIndex = 0;
            pic_preView.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 422);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 3;
            label3.Text = "前景色：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 422);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 3;
            label4.Text = "背景色：";
            // 
            // p_foreColor
            // 
            p_foreColor.BorderStyle = BorderStyle.FixedSingle;
            p_foreColor.Location = new Point(301, 422);
            p_foreColor.Margin = new Padding(4, 4, 4, 4);
            p_foreColor.Name = "p_foreColor";
            p_foreColor.Size = new Size(35, 42);
            p_foreColor.TabIndex = 4;
            p_foreColor.TabStop = false;
            p_foreColor.Click += p_foreColor_Click;
            // 
            // p_backColor
            // 
            p_backColor.BorderStyle = BorderStyle.FixedSingle;
            p_backColor.Location = new Point(475, 422);
            p_backColor.Margin = new Padding(4, 4, 4, 4);
            p_backColor.Name = "p_backColor";
            p_backColor.Size = new Size(35, 42);
            p_backColor.TabIndex = 4;
            p_backColor.TabStop = false;
            p_backColor.Click += p_backColor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(320, 515);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(88, 42);
            button1.TabIndex = 5;
            button1.Text = "保 存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(429, 515);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(88, 42);
            button2.TabIndex = 5;
            button2.Text = "关 闭";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 577);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(308, 17);
            label5.TabIndex = 6;
            label5.Text = "注：每编辑好一个方块后点击保存，颜色方案才会生效。";
            // 
            // setBlockColor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 616);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(p_backColor);
            Controls.Add(p_foreColor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pic_preView);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "setBlockColor";
            Text = "设置方块的颜色";
            Load += setBlockColor_Load;
            Paint += setBlockColor_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_preView).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_foreColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_backColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_preView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox p_foreColor;
        private System.Windows.Forms.PictureBox p_backColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}