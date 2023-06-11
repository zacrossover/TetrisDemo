using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDemo
{
    public class Square
    {
        public Point location;
        public Size size;
        public Color foreColor;
        public Color backColor;
        public Square(Size initSize, Color initForeColor, Color initBackColor)
        {
            size = initSize;
            foreColor = initForeColor;
//            backColor = initBackColor;
        }
        //画方块
        public void Draw(System.IntPtr winHandle)
        {
            Graphics g = Graphics.FromHwnd(winHandle);
            GraphicsPath gp = new GraphicsPath();
            Rectangle rec = new Rectangle(location, size);
            gp.AddRectangle(rec);
//            Color[] surroundColor = new Color[] { backColor };
/*            PathGradientBrush pb = new PathGradientBrush(gp);
            pb.CenterColor = foreColor;
            pb.SurroundColors = surroundColor;*/
            SolidBrush  sb = new SolidBrush(foreColor);
            Pen pen = new Pen(Color.White);
            g.FillRectangle(sb, rec);
            g.DrawRectangle(pen,rec);
/*            g.FillPath(pb, gp);
            g.FillRectangle(pb, rec);*/
        }
        //擦除方块
        public void Erase(System.IntPtr winHandle)
        {
            Graphics g = Graphics.FromHwnd(winHandle);
            Rectangle rec = new Rectangle(location, size);
            g.FillRectangle(new SolidBrush(GameField.BackColor), rec);
        }
    }
}
