﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisDemo
{
    public partial class setBlockColor : Form
    {
        Form1 form1 = new Form1();
        public setBlockColor()
        {
            InitializeComponent();
        }
        private Block someBlock;
        private int currentBlock = 0;   //0代表没选择，1，2，3……代表选择的图形框号
        private Color gameFieldBgC = GameField.BackColor;
        private void setBlockColor_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void setBlockColor_Paint(object sender, PaintEventArgs e)
        {
            initalit();
        }
        public void initalit()
        {
            pictureBox1.BackColor = gameFieldBgC;
            pictureBox2.BackColor = gameFieldBgC;
            pictureBox3.BackColor = gameFieldBgC;
            pictureBox4.BackColor = gameFieldBgC;
            pictureBox5.BackColor = gameFieldBgC;
            pictureBox6.BackColor = gameFieldBgC;
            pictureBox7.BackColor = gameFieldBgC;
            Application.DoEvents();
            //图片框1号：方块
            someBlock = new BlockO(new Point(35, 27));
            someBlock.Draw(pictureBox1.Handle);

            //图片框2号：直线
            someBlock = new BlockI(new Point(20, 35));
            someBlock.Draw(pictureBox2.Handle);

            //图片框3号：J
            someBlock = new BlockJ(new Point(42, 20));
            someBlock.Draw(pictureBox3.Handle);

            //图片框4号：L
            someBlock = new BlockL(new Point(42, 20));
            someBlock.Draw(pictureBox4.Handle);

            //图片框5号：T
            someBlock = new BlockT(new Point(27, 27));
            someBlock.Draw(pictureBox5.Handle);

            //图片框6号：Z
            someBlock = new BlockZ(new Point(27, 27));
            someBlock.Draw(pictureBox6.Handle);

            //图片框7号：S
            someBlock = new BlockS(new Point(27, 27));
            someBlock.Draw(pictureBox7.Handle);
            Application.DoEvents();
        }
        /*关闭*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*单击某个图片框*/
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox send = (PictureBox)sender;
            currentBlock = int.Parse(send.Name.Substring(send.Name.Length - 1, 1));
            pic_preView.Refresh();
            pic_preView.BackColor = gameFieldBgC;
            Application.DoEvents();
            someBlock = form1.createBlock(new Point(45, 40), (Block.BlockTypes)currentBlock);
            someBlock.Draw(pic_preView.Handle);

            p_foreColor.BackColor = GameField.BlockForeColor[currentBlock - 1];
            p_backColor.BackColor = GameField.BlockBackColor[currentBlock - 1];
        }
        /*选择前景色*/
        private void p_foreColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                p_foreColor.BackColor = colorDialog1.Color;
            pic_preView.Refresh();
            someBlock = form1.createBlock(new Point(45, 40), (Block.BlockTypes)currentBlock, p_foreColor.BackColor, p_backColor.BackColor);
            someBlock.Draw(pic_preView.Handle);
        }
        /*选择背景色*/
        private void p_backColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                p_backColor.BackColor = colorDialog1.Color;
            pic_preView.Refresh();
            someBlock = form1.createBlock(new Point(45, 40), (Block.BlockTypes)currentBlock, p_foreColor.BackColor, p_backColor.BackColor);
            someBlock.Draw(pic_preView.Handle);
        }
        //保存
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentBlock != 0)
            {
                GameField.BlockForeColor[currentBlock - 1] = p_foreColor.BackColor;
                GameField.BlockBackColor[currentBlock - 1] = p_backColor.BackColor;
                //Form1.ActiveForm.Refresh();
                //重画预览框的图片
                someBlock = form1.createBlock(new Point(45, 40), (Block.BlockTypes)currentBlock);
                someBlock.Draw(pic_preView.Handle);
                //游戏设置改变
                GameField.isChanged = true;
            }
        }
    }
}
