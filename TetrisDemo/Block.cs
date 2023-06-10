using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDemo
{
    public abstract class Block
    {
        public Square square1;  //组成block的四个小方块
        public Square square2;
        public Square square3;
        public Square square4;

        public const int squareSize = GameField.SquareSize; //小方块的边长
        public enum BlockTypes
        {
            undefined = 0,
            square = 1,
            line = 2,
            J = 3,
            L = 4,
            T = 5,
            Z = 6,
            S = 7,
            One = 8
        };//一共有7种形状
        public BlockTypes blockType;  //方块的形状
        //七个小方块的颜色数组
        public Color foreColor;
        public Color backColor;
        //方块的方向
        public enum RotateDirections
        {
            North = 1,
            East = 2,
            South = 3,
            West = 4
        };
        public RotateDirections myRotation = RotateDirections.North;

        /*画方块*/
        public void Draw(System.IntPtr winHandle)
        {
            square1.Draw(winHandle);
            square2.Draw(winHandle);
            square3.Draw(winHandle);
            square4.Draw(winHandle);
        }
        /*擦方块*/
        public void Erase(System.IntPtr winHandle)
        {
            square1.Erase(winHandle);
            square2.Erase(winHandle);
            square3.Erase(winHandle);
            square4.Erase(winHandle);
        }

        /*移动*/
        public virtual bool down()
        {
            //检测是否可以下移
            if (GameField.isEmpty(square1.location.X / squareSize, square1.location.Y / squareSize + 1) &&
                GameField.isEmpty(square2.location.X / squareSize, square2.location.Y / squareSize + 1) &&
                GameField.isEmpty(square3.location.X / squareSize, square3.location.Y / squareSize + 1) &&
                GameField.isEmpty(square4.location.X / squareSize, square4.location.Y / squareSize + 1))
            {
                Erase(GameField.winHandle);
                square1.location = new Point(square1.location.X, square1.location.Y + squareSize);
                square2.location = new Point(square2.location.X, square2.location.Y + squareSize);
                square3.location = new Point(square3.location.X, square3.location.Y + squareSize);
                square4.location = new Point(square4.location.X, square4.location.Y + squareSize);
                Draw(GameField.winHandle);
                return true;
            }
            else  //如果不能下移了
            {
                GameField.stopSquare(square1, square1.location.X / squareSize, square1.location.Y / squareSize);
                GameField.stopSquare(square2, square2.location.X / squareSize, square2.location.Y / squareSize);
                GameField.stopSquare(square3, square3.location.X / squareSize, square3.location.Y / squareSize);
                GameField.stopSquare(square4, square4.location.X / squareSize, square4.location.Y / squareSize);
                return false; //表示可以弹出下一个block了
            }
        }
        public bool left()
        {
            //检测是否可以左移
            if (GameField.isEmpty(square1.location.X / squareSize - 1, square1.location.Y / squareSize) &&
                GameField.isEmpty(square2.location.X / squareSize - 1, square2.location.Y / squareSize) &&
                GameField.isEmpty(square3.location.X / squareSize - 1, square3.location.Y / squareSize) &&
                GameField.isEmpty(square4.location.X / squareSize - 1, square4.location.Y / squareSize))
            {
                Erase(GameField.winHandle);
                square1.location = new Point(square1.location.X - squareSize, square1.location.Y);
                square2.location = new Point(square2.location.X - squareSize, square2.location.Y);
                square3.location = new Point(square3.location.X - squareSize, square3.location.Y);
                square4.location = new Point(square4.location.X - squareSize, square4.location.Y);
                Draw(GameField.winHandle);
                return true;
            }
            else  //如果不能左移了
            {
                return false;
            }
        }
        public bool right()
        {
            //检测是否可以右移
            if (GameField.isEmpty(square1.location.X / squareSize + 1, square1.location.Y / squareSize) &&
                GameField.isEmpty(square2.location.X / squareSize + 1, square2.location.Y / squareSize) &&
                GameField.isEmpty(square3.location.X / squareSize + 1, square3.location.Y / squareSize) &&
                GameField.isEmpty(square4.location.X / squareSize + 1, square4.location.Y / squareSize))
            {
                Erase(GameField.winHandle);
                square1.location = new Point(square1.location.X + squareSize, square1.location.Y);
                square2.location = new Point(square2.location.X + squareSize, square2.location.Y);
                square3.location = new Point(square3.location.X + squareSize, square3.location.Y);
                square4.location = new Point(square4.location.X + squareSize, square4.location.Y);
                Draw(GameField.winHandle);
                return true;
            }
            else  //如果不能右移了
            {
                return false;
            }
        }
        /*旋转block*/
         public abstract void Rotate();
        /*检测是否到顶*/
        public int Top()
        {
            return Math.Min(square1.location.Y, Math.Min(square2.location.Y, Math.Min(square3.location.Y, square4.location.Y)));
        }
    }
}
