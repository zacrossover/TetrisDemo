using System.Reflection.Emit;
using System.Windows.Forms;
using static TetrisDemo.Block;

namespace TetrisDemo
{
    public partial class Form1 : Form
    {
        private Block currentBlock; //��ǰ�����еķ���
        private Block nextBlock;   //��һ���������ֵķ���
        private Point startLocation = new Point(GameField.SquareSize * 8, 0);  //���������λ��
        private int score = 0;            //��һ���
        private bool stillRuning = false; //��Ϸ���п���
        private int speedLevel = 1;            //����ٶȵȼ�
        private int level = 1;
        private enum speeds
        {
            slower = 1000,
            slow = 800,
            quick = 500,
            quicker = 350,
            quickest = 250
        }; //��Ϸ�ٶȣ�����ԽСԽ��
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameField.BackColor = picBackGround.BackColor;
            GameField.winHandle = picBackGround.Handle;
            timer1.Interval = (int)speeds.slower;
            //��ȡ�Զ�������
            getSettings();
        }
        /*���ش���ʱ�������ļ�Setting.ini�ж�ȡ��Ϸ����*/
        private void getSettings()
        {
            if (!File.Exists("Setting.ini"))
                return;
            FileStream fs = new FileStream("Setting.ini", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string line1 = sr.ReadLine();
            string line2 = sr.ReadLine();
            string line3 = sr.ReadLine();
            if (line1 != null && line1.Split('=').Length > 1)
            {
                GameField.BackColor = Color.FromArgb(int.Parse(line1.Split('=')[1]));
                picBackGround.BackColor = GameField.BackColor;
            }
            if (line2 != null && line2.Split('=').Length > 1)
                GameField.BlockForeColor = strToColor(line2.Split('=')[1]);
            if (line3 != null && line3.Split('=').Length > 1)
                GameField.BlockBackColor = strToColor(line3.Split('=')[1]);
            sr.Close();
            fs.Close();
        }
        /*�����Ϸ���ñ����ģ����µ����ñ��浽Setting.ini*/
        private void saveSettings()
        {
            FileStream fs = new FileStream("Setting.ini", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("GameFieldColor=" + GameField.BackColor.ToArgb());
            sw.WriteLine("BlockFroeColor=" + colorToStr(GameField.BlockForeColor));
            sw.WriteLine("BlockBackColor=" + colorToStr(GameField.BlockBackColor));
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        /*���ַ�����س���ɫ����*/
        private Color[] strToColor(string str)
        {
            string[] strs = str.Split(',');
            if ((strs.Length - 1) != 7)
                return null;
            Color[] colors = new Color[7];
            for (int i = 0; i < strs.Length - 1; i++)
                colors[i] = Color.FromArgb(int.Parse(strs[i]));
            return colors;
        }
        /*����ɫ��ɿɶ��ַ���*/
        private string colorToStr(Color[] colors)
        {
            string result = "";
            for (int i = 0; i < colors.Length; i++)
                result += colors[i].ToArgb() + ",";
            return result;
        }

        /// <summary>
        /// ����Ҫ����д������Ӧ����������޷����Ʒ���
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }
            return base.ProcessDialogKey(keyData);
        }

        /*���̲���*/
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: if (!currentBlock.right()) GameField.PlaySound("CanNotDo"); break;//�����ƶ�
                case Keys.Left: if (!currentBlock.left()) GameField.PlaySound("CanNotDo"); break; //�����ƶ�
                case Keys.Up: currentBlock.Rotate(); break; //��ת
                case Keys.Down: while (currentBlock.down()) ; break; //���¼���
                case Keys.Space:                           //�ո���ͣ
                    timer1.Enabled = !timer1.Enabled;
                    if (!timer1.Enabled)
                        showMsg("�� ͣ");
                    else
                        msg.SendToBack();
                    break;
                case Keys.Enter: //�س�������Ϸ
                    beginGame();
                    break;
            }
            picBackGround.Focus();
        }

        /*��Ϸʱ��*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!stillRuning)
                return;

            //����Ƿ񻹿�������
            if (!currentBlock.down())
            {
                if (currentBlock.Top() == 0)
                {//�����������Ϸ����
                    showMsg("Game Over��");
                    stillRuning = false;
                    timer1.Stop();
                    return;
                }
                //����������������
                int eraseLines = GameField.CheckLines();
                if (eraseLines > 0)
                {
                    score += GameField.width * eraseLines;
                    t_score.Text = score.ToString();
                    
                    picBackGround.Invalidate();
                    Application.DoEvents();
                    GameField.Redraw();
                }
                //������һ��block
                currentBlock = createBlock(startLocation, nextBlock.blockType);
                currentBlock.Draw(GameField.winHandle);
                pic_preView.Refresh();
                nextBlock = createBlock(new Point(80, 50), BlockTypes.undefined);
                nextBlock.Draw(pic_preView.Handle);
            }
            //currentBlock.down();
        }

        /*�����ػ�*/
        private void Form1_Activated(object sender, EventArgs e)
        {
            picBackGround.Invalidate();
            Application.DoEvents();
            GameField.Redraw();
        }
        /*�رմ���ʱ����ʾ�Ƿ񱣴�����*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GameField.isChanged && MessageBox.Show("�����Ѹı䣬�Ƿ����˳�ǰ���棿", "��ʾ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                saveSettings();
        }
        #region �˵�����
        /*��ʼ��Ϸ*/
        private void ��ʼToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            beginGame();
        }
        //��ʼ��Ϸ�ķ���
        private void beginGame()
        {
            msg.SendToBack();   //����ʾ��������
            ��ʼToolStripMenuItem.Enabled = false;
            ��ͣToolStripMenuItem1.Enabled = true;
            ����ToolStripMenuItem.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            if (currentBlock == null)
            {//��һ�ο�ʼ
                currentBlock = createBlock(startLocation, BlockTypes.undefined);
                currentBlock.Draw(GameField.winHandle);
                nextBlock = createBlock(new Point(80, 50), BlockTypes.undefined);
                nextBlock.Draw(pic_preView.Handle);
                stillRuning = true;
                timer1.Start();
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        /*��ͣ��Ϸ*/
        private void ��ͣToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            showMsg("�� ͣ");
            ��ʼToolStripMenuItem.Enabled = true;
            ��ͣToolStripMenuItem1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        /*������Ϸ*/
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stillRuning = false;
            timer1.Stop();
            currentBlock = null;
            showMsg("�� ��");
            ����ToolStripMenuItem.Enabled = false;
            ��ͣToolStripMenuItem1.Enabled = false;
            ��ʼToolStripMenuItem.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            picBackGround.Refresh();
            pic_preView.Refresh();
        }

        /*���¿�ʼһ��*/
        private void ���¿�ʼToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            picBackGround.Refresh();   //ˢ����Ϸ��
            pic_preView.Refresh();     //ˢ��Ԥ����
            GameField.arriveBlock = new Square[GameField.width, GameField.height]; //�������С����
            GameField.arrBitBlock = new int[GameField.height];
            score = 0;           //���¼������
            t_score.Text = "0";
            level = 1;
            msg.SendToBack();   //����ʾ��������
            currentBlock = createBlock(startLocation, BlockTypes.undefined);
            currentBlock.Draw(GameField.winHandle);
            nextBlock = createBlock(new Point(80, 50), BlockTypes.undefined);
            nextBlock.Draw(pic_preView.Handle);
            ��ʼToolStripMenuItem.Enabled = false;
            ��ͣToolStripMenuItem1.Enabled = true;
            ����ToolStripMenuItem.Enabled = true;
            stillRuning = true;
            timer1.Start();
        }

        /*�˳���Ϸ*/
        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stillRuning = false;
            timer1.Stop();
            this.Close();
        }

        /*��ʾ��ʾ��*/
        private void showMsg(string str)
        {
            msg.Text = str;
            msg.Left = picBackGround.Left + picBackGround.Width / 2 - msg.Width / 2;
            msg.BringToFront();
        }
        /*����˵��*/
        private void ����˵��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help helps = new help();
            helps.Show();
        }
        /*����*/
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();
        }
        /*������ɫ����*/
        private void ������ɫ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setGameFieldBgColor sb = new setGameFieldBgColor();
            sb.ShowDialog();
            picBackGround.BackColor = GameField.BackColor;
        }
        /*������ɫ����*/
        private void ������ɫ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setBlockColor sb = new setBlockColor();
            sb.ShowDialog();
        }
        /*�ٶ�ѡ�����*/
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(����ToolStripMenuItem);
            timer1.Interval = (int)speeds.slower;
            speedLevel = 1;
        }
        /*�ٶ�ѡ����*/
        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(��ToolStripMenuItem);
            timer1.Interval = (int)speeds.slow;
            speedLevel = 2;
        }
        /*�ٶ�ѡ���*/
        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(��ToolStripMenuItem);
            timer1.Interval = (int)speeds.quick;
            speedLevel = 3;
        }
        /*�ٶ�ѡ��Ͽ�*/
        private void �Ͽ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(�Ͽ�ToolStripMenuItem);
            timer1.Interval = (int)speeds.quicker;
            speedLevel = 3;
        }
        /*�ٶ�ѡ��ǳ���*/
        private void �ǳ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(�ǳ���ToolStripMenuItem);
            timer1.Interval = (int)speeds.quickest;
            speedLevel = 5;
        }
        /*�ٶ�ѡ����Ҫ�õ��ķ���*/
        public void changeChecked(ToolStripMenuItem oo)
        {
            ����ToolStripMenuItem.Checked = false;
            ��ToolStripMenuItem.Checked = false;
            ��ToolStripMenuItem.Checked = false;
            �Ͽ�ToolStripMenuItem.Checked = false;
            �ǳ���ToolStripMenuItem.Checked = false;
            oo.Checked = true;
        }
        private void �ָ�Ĭ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameField.BackColor = Color.Gainsboro;
            picBackGround.BackColor = Color.Gainsboro;
            GameField.BlockForeColor = new Color[] { Color.Blue, Color.Beige, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkRed, Color.DarkSeaGreen };
            GameField.BlockBackColor = new Color[] { Color.LightCyan, Color.DarkSeaGreen, Color.Beige, Color.Beige, Color.Beige, Color.Beige, Color.Beige, Color.Beige };
            saveSettings();
            GameField.isChanged = false;
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            beginGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            showMsg("�� ͣ");
            ��ʼToolStripMenuItem.Enabled = true;
            ��ͣToolStripMenuItem1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            stillRuning = false;
            timer1.Stop();
            currentBlock = null;
            showMsg("�� ��");
            ����ToolStripMenuItem.Enabled = false;
            ��ͣToolStripMenuItem1.Enabled = false;
            ��ʼToolStripMenuItem.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            picBackGround.Refresh();
            pic_preView.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            picBackGround.Refresh();   //ˢ����Ϸ��
            pic_preView.Refresh();     //ˢ��Ԥ����
            GameField.arriveBlock = new Square[GameField.width, GameField.height]; //�������С����
            GameField.arrBitBlock = new int[GameField.height];
            score = 0;           //���¼������
            t_score.Text = "0";
            level = 1;
            msg.SendToBack();   //����ʾ��������
            currentBlock = createBlock(startLocation, BlockTypes.undefined);
            currentBlock.Draw(GameField.winHandle);
            nextBlock = createBlock(new Point(80, 50), BlockTypes.undefined);
            nextBlock.Draw(pic_preView.Handle);
            ��ʼToolStripMenuItem.Enabled = false;
            ��ͣToolStripMenuItem1.Enabled = true;
            ����ToolStripMenuItem.Enabled = true;
            stillRuning = true;
            timer1.Start();
        }
        public Block createBlock(Point loc, BlockTypes blockTypes)
        {
            Random rand = new Random();
            if (blockTypes == BlockTypes.undefined)
            {
                blockTypes = (BlockTypes)(rand.Next(8) + 1);
            }
            Block block;
            switch (blockTypes)
            {
                case BlockTypes.square:
                    block = new BlockO(loc);
                    break;
                case BlockTypes.line:
                    block = new BlockI(loc);
                    break;
                case BlockTypes.T:
                    block = new BlockT(loc);
                    break;
                case BlockTypes.J:
                    block = new BlockJ(loc);
                    break;
                case BlockTypes.L:
                    block = new BlockL(loc);
                    break;
                case BlockTypes.Z:
                    block = new BlockZ(loc);
                    break;
                case BlockTypes.S:
                    block = new BlockS(loc);
                    break;
                case BlockTypes.One:
                    block = new BlockOne(loc);
                    break;
                default:
                    block = new BlockO(loc);
                    break;
            }
            return block;
        }

        public Block createBlock(Point loc, BlockTypes blockTypes, Color c1, Color c2)
        {
            Random rand = new Random();
            if (blockTypes == BlockTypes.undefined)
            {
                blockTypes = (BlockTypes)(rand.Next(8) + 1);
            }
            Block block;
            switch (blockTypes)
            {
                case BlockTypes.square:
                    block = new BlockO(loc, c1, c2);
                    break;
                case BlockTypes.line:
                    block = new BlockI(loc, c1, c2);
                    break;
                case BlockTypes.T:
                    block = new BlockT(loc, c1, c2);
                    break;
                case BlockTypes.J:
                    block = new BlockJ(loc, c1, c2);
                    break;
                case BlockTypes.L:
                    block = new BlockL(loc, c1, c2);
                    break;
                case BlockTypes.Z:
                    block = new BlockZ(loc, c1, c2);
                    break;
                case BlockTypes.S:
                    block = new BlockS(loc, c1, c2);
                    break;
                case BlockTypes.One:
                    block = new BlockOne(loc, c1, c2);
                    break;
                default:
                    block = new BlockO(loc, c1, c2);
                    break;
            }
            return block;
        }

        private void changeSpeed()
        {
            double ratio = 1.0;
            if (score < 100)
            {

            }
            else if (score >= 100 && score < 300)
            {
                level = 2;
                ratio = 0.8;
            }
            else if (score >= 300 && score <= 600)
            {
                level = 3;
                ratio = 0.6;
            }
            else if (score >= 600 && score <= 1000)
            {
                level = 4;
                ratio = 0.4;
            }
            else if (score >= 1500)
            {
                level = 5;
                ratio = 0.2;
            }


            if (speedLevel == 1)
            {
                timer1.Interval = (int)((double)speeds.slower * ratio);
            }
            else if (speedLevel == 2)
            {
                timer1.Interval = (int)((double)speeds.slow * ratio);
            }
            else if (speedLevel == 3)
            {
                timer1.Interval = (int)((double)speeds.quick * ratio);
            }
            else if (speedLevel == 4)
            {
                timer1.Interval = (int)((double)speeds.quicker * ratio);
            }
            else if (speedLevel == 5)
            {
                timer1.Interval = (int)((double)speeds.quickest * ratio);
            }

        }

    }
}