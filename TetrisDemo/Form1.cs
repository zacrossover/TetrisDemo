using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Media;
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

        private string name = "";//�������

        private list lst = new list();
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
                //                GameField.BlockBackColor = strToColor(line3.Split('=')[1]);
                sr.Close();
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
                    GameField.PlaySound("GameOver");
                    stillRuning = false;
                    timer1.Stop();
                    lst.AddRanking(name, score);
                    return;
                }
                //����������������
                int eraseLines = GameField.CheckLines();
                if (eraseLines > 0)
                {
                    score += GameField.width * eraseLines;
                    t_score.Text = score.ToString();
                    changeSpeed();
                    printLevel(timer1.Interval);
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

        #region �˵�����

        //��ʼ��Ϸ�ķ���
        private void beginGame()
        {
            msg.SendToBack();   //����ʾ��������

            button1.Enabled = false;
            button2.Enabled = true;
            //button3.Enabled = true;
            if (currentBlock == null)
            {//��һ�ο�ʼ
                GameField.arriveBlock = new Square[GameField.width, GameField.height]; //�������С����
                GameField.arrBitBlock = new int[GameField.height];
                currentBlock = createBlock(startLocation, BlockTypes.undefined);
                currentBlock.Draw(GameField.winHandle);
                nextBlock = createBlock(new Point(80, 50), BlockTypes.undefined);
                nextBlock.Draw(pic_preView.Handle);
                stillRuning = true;
                // ����һ�������
                name = "";
                if (InputBox("��������", "����������������", ref name) == DialogResult.OK)
                {
                    // ���ȷ���󣬽������������ʾ�ڱ�ǩ��
                    label1.Text = "���ã�" + name + "��";
                }
                printLevel(timer1.Interval);
                timer1.Start();
            }
            else
            {
                timer1.Enabled = true;
            }
            //m_bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            //m_bw.RunWorkerAsync();
            GameField.PlayBackGroundSound();
        }

        /*�˳���Ϸ*/
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stillRuning = false;
            lst.AddRanking(name, score);
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
        private void OperatingToolStripMenuItem_Click(object sender, EventArgs e)
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

        /*�ٶ�ѡ�����*/
        private void SlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(SlowerToolStripMenuItem);
            timer1.Interval = (int)speeds.slower;
            printLevel(timer1.Interval);
        }
        /*�ٶ�ѡ����*/
        private void SlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(SlowToolStripMenuItem);
            timer1.Interval = (int)speeds.slow;
            printLevel(timer1.Interval);
        }
        /*�ٶ�ѡ���*/
        private void QuickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(QuickToolStripMenuItem);
            timer1.Interval = (int)speeds.quick;
            printLevel(timer1.Interval);
        }
        /*�ٶ�ѡ��Ͽ�*/
        private void QuickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(QuickerToolStripMenuItem);
            timer1.Interval = (int)speeds.quicker;
            printLevel(timer1.Interval);
        }
        /*�ٶ�ѡ��ǳ���*/
        private void QuickestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(QuickestToolStripMenuItem);
            timer1.Interval = (int)speeds.quickest;
            printLevel(timer1.Interval);
        }

        private void RankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lst.StartPosition = FormStartPosition.CenterScreen;
            lst.ShowDialog();
        }
        #endregion
        /*�ٶ�ѡ����Ҫ�õ��ķ���*/
        public void changeChecked(ToolStripMenuItem oo)
        {
            SlowerToolStripMenuItem.Checked = false;
            SlowToolStripMenuItem.Checked = false;
            QuickToolStripMenuItem.Checked = false;
            QuickerToolStripMenuItem.Checked = false;
            QuickestToolStripMenuItem.Checked = false;
            oo.Checked = true;
        }

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

            button1.Enabled = true;
            button2.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lst.AddRanking(name, score);
            picBackGround.Refresh();   //ˢ����Ϸ��
            pic_preView.Refresh();     //ˢ��Ԥ����
            GameField.arriveBlock = new Square[GameField.width, GameField.height]; //�������С����
            GameField.arrBitBlock = new int[GameField.height];
            score = 0;           //���¼������
            t_score.Text = "0";
            timer1.Interval = (int)speeds.slower;
            printLevel(timer1.Interval);
            msg.SendToBack();   //����ʾ��������
            currentBlock = createBlock(startLocation, BlockTypes.undefined);
            currentBlock.Draw(GameField.winHandle);
            nextBlock = createBlock(new Point(80, 50), BlockTypes.undefined);
            nextBlock.Draw(pic_preView.Handle);
            changeChecked(SlowerToolStripMenuItem);
            stillRuning = true;
            timer1.Start();
        }
        // �Զ��������
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "ȷ��\n";
            buttonCancel.Text = "ȡ��\n";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 20);
            textBox.SetBounds(12, 56, 372, 40);
            buttonOk.SetBounds(228, 102, 75, 43);
            buttonCancel.SetBounds(309, 102, 75, 43);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new System.Drawing.Size(396, 147);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
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
            //double ratio = 1.0;
            if (score < 100)
            {

            }
            else if (score >= 100 && score < 300)
            {
                if (timer1.Interval >= (int)speeds.slower)
                {
                    timer1.Interval = (int)speeds.slow;
                }

            }
            else if (score >= 300 && score <= 600)
            {
                if (timer1.Interval >= (int)speeds.slow)
                {
                    timer1.Interval = (int)speeds.quick;
                }
            }
            else if (score >= 600 && score <= 1000)
            {
                if (timer1.Interval >= (int)speeds.quick)
                {
                    timer1.Interval = (int)speeds.quicker;
                }
            }
            else if (score >= 1500)
            {
                if (timer1.Interval >= (int)speeds.quicker)
                {
                    timer1.Interval = (int)speeds.quickest;
                }
            }

        }

        private void printLevel(int interval)
        {
            if (interval == (int)speeds.slower)
            {
                label2.Text = "1";
            }
            else if (interval == (int)speeds.slow)
            {
                label2.Text = "2";
            }
            else if (interval == (int)speeds.quick)
            {
                label2.Text = "3";
            }
            else if (interval == (int)speeds.quicker)
            {
                label2.Text = "4";
            }
            else if (interval == (int)speeds.quickest)
            {
                label2.Text = "5";
            }
        }
        private void Form1_Closed(object sender, EventArgs e)
        {
            stillRuning = false;
            lst.AddRanking(name, score);
            timer1.Stop();
        }

    }
}