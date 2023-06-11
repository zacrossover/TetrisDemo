using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;


namespace TetrisDemo
{
    internal class GameField
    {
        public const int width = 20;           //场景的宽，以方块个数为单位
        public const int height = 30;
        public const int SquareSize = 15;      //每个四分之一小方块的边长
        public static Color BackColor;         //场景的背景色
        public static System.IntPtr winHandle; //场景的handle
        public static Color[] BlockForeColor = { Color.Blue, Color.DeepPink, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkRed, Color.DarkSeaGreen };
//        public static Color[] BlockBackColor = { Color.LightCyan, Color.DarkSeaGreen, Color.Beige, Color.Beige, Color.Beige, Color.Beige, Color.Beige, Color.Beige };
        public static bool isChanged = false;
        
        public static SoundPlayer backSound = new SoundPlayer();
        public static SecondaryBuffer secBuffer;//缓冲区对象    
        public static Device secDev;//设备对象    

        public static Square[,] arriveBlock = new Square[width, height]; //保存已经不能再下落了的方块
        public static int[] arrBitBlock = new int[height];  //位数组：当某个位置有方块时，该行的该位为1,相当于2维数组
        private const int bitEmpty = 0x0;      //某一行全是0
        private const int bitFull = 0xFFFFF;   //某一行全是1

        /*检测是否为空*/
        public static bool isEmpty(int x, int y)
        {
            //先检测是否越界
            if (y < 0 || y >= height)
                return false;
            if (x < 0 || x >= width)
                return false;
            //然后检测是否为空
            if ((arrBitBlock[y] & (1 << x)) != 0)
                return false;
            else
                return true;
        }
        /*将方块停住*/
        public static void stopSquare(Square sq, int x, int y)
        {
            arriveBlock[x, y] = sq;
            arrBitBlock[y] = arrBitBlock[y] | (1 << x);
        }
        /*检测行是否满 
         * 返回：成功消除的行数和  （方便统计分数）
         */
        public static int CheckLines()
        {
            //从最下面一行往上检测，当某行为空或到顶时结束
            int lineFullCount = 0;
            int y = height - 1;
            while (y >= 0 && arrBitBlock[y] != bitEmpty)
            {
                if (arrBitBlock[y] == bitFull)
                {
                    lineFullCount++; //消除一行记分
                    arrBitBlock[y] = bitEmpty;//消除该行的block
                    PlaySound("FinishOneLine");  //播放声音
                    for (int x = 0; x < width; x++) //消除该行的block
                        arriveBlock[x, y] = null;
                    //将该行之上的block下移，如果到顶则不执行
                    for (int i = y; i - 1 >= 0; i--)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            if ((arrBitBlock[i - 1] & (1 << x)) != 0) //如果上方有block
                            {
                                arriveBlock[x, i - 1].location = new Point(arriveBlock[x, i - 1].location.X, arriveBlock[x, i - 1].location.Y + SquareSize);
                                arriveBlock[x, i] = arriveBlock[x, i - 1];
                            }
                        }
                        arrBitBlock[i] = arrBitBlock[i - 1];
                    }
                }
                else  //当消除一行后指针不下移，当没有消除的时候指针才下移
                    y--;
            }//while循环结束
            return lineFullCount;
        }
        /*播放声音*/
        public static void PlaySound(string soundstr)
        {
            SoundPlayer sound = new SoundPlayer();
            switch (soundstr)
            {
                case "FinishOneLine": //消除一行的声音
                    if (!File.Exists("FinishOneLine.wav")) return;
                    sound.SoundLocation = "FinishOneLine.wav";
                    break;
                case "CanNotDo": //当无法操作时
                    if (!File.Exists("CanNotDo.wav")) return;
                    sound.SoundLocation = "CanNotDo.wav";
                    break;
                case "GameOver": //当GameOver时
                    if (!File.Exists("GameOver.wav")) return;
                    sound.SoundLocation = "GameOver.wav";
                    break;
            }
            sound.Play();
        }
        /*播放背景声音*/
        public static void PlayBackGroundSound()
        {
            /*                       secDev = new Device();
                                    //secDev.SetCooperativeLevel(this, CooperativeLevel.Normal);//设置设备协作级别    
                                    secBuffer = new SecondaryBuffer("BackGround.wav", secDev);//创建辅助缓冲区    
                                    secBuffer.Play(0, BufferPlayFlags.Looping);//设置缓冲区为默认播放 */


            if (!File.Exists("BackGround.wav")) return;
            backSound.SoundLocation = "BackGround.wav";

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += (s, e) =>
            {
                backSound.PlayLooping();
                timer.Start();
            };
            timer.Interval = 25000;
            backSound.PlayLooping();
            timer.Start();
        }
        /*停止播放背景声音*/
        public static void StopBackGroundSound()
        {
            //secBuffer.Stop();
            backSound.Stop();
        }
        /*重画*/
        public static void Redraw()
        {
            for (int y = height - 1; y >= 0; y--)
                if (arrBitBlock[y] != bitEmpty)
                    for (int x = 0; x < width; x++)
                        if ((arrBitBlock[y] & (1 << x)) != 0)
                            arriveBlock[x, y].Draw(winHandle);
        }
    }
}