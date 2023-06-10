namespace TetrisDemo
{
    partial class list
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
            lvRanking = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvRanking
            // 
            lvRanking.ItemHeight = 24;
            lvRanking.Location = new Point(32, 60);
            lvRanking.Name = "lvRanking";
            lvRanking.Size = new Size(487, 484);
            lvRanking.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(202, 24);
            label1.TabIndex = 1;
            label1.Text = "姓名                        得分";
            label1.Click += label1_Click;
            // 
            // list
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 562);
            Controls.Add(label1);
            Controls.Add(lvRanking);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "list";
            Text = "排行榜";
            Load += list_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lvRanking;
        private Label label1;
    }
}