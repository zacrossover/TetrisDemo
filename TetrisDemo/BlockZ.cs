using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TetrisDemo.Block;

namespace TetrisDemo
{
    internal class BlockZ:Block
    {
        public BlockZ(Point thisLocation)
        {
            blockType = BlockTypes.Z;
            foreColor = GameField.BlockForeColor[5];
            backColor = GameField.BlockBackColor[5];
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, foreColor, backColor);
            square2 = new Square(squareS, foreColor, backColor);
            square3 = new Square(squareS, foreColor, backColor);
            square4 = new Square(squareS, foreColor, backColor);
            square1.location = new Point(thisLocation.X, thisLocation.Y);
            square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
            square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
            square4.location = new Point(thisLocation.X + 2 * squareSize, thisLocation.Y + squareSize);
        }

        public BlockZ(Point thisLocation,Color fc, Color bc)
        {
            blockType = BlockTypes.Z;
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, fc, bc);
            square2 = new Square(squareS, fc, bc);
            square3 = new Square(squareS, fc, bc);
            square4 = new Square(squareS, fc, bc);
            square1.location = new Point(thisLocation.X, thisLocation.Y);
            square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
            square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
            square4.location = new Point(thisLocation.X + 2 * squareSize, thisLocation.Y + squareSize);
        }

        public override void Rotate()
        {
            Point oldPosition1 = square1.location;
            Point oldPosition2 = square2.location;
            Point oldPosition3 = square3.location;
            Point oldPosition4 = square4.location;
            //保存当前的方向
            RotateDirections oldRotation = myRotation;
            //开始试着旋转方块，旋转方向：顺时针方向 旋转中心点为形状拐点
            Erase(GameField.winHandle);
            switch (myRotation)
            {
                case RotateDirections.North:
                    myRotation = RotateDirections.East;
                    square1.location = new Point(square2.location.X, square2.location.Y - squareSize);
                    square3.location = new Point(square2.location.X - squareSize, square2.location.Y);
                    square4.location = new Point(square2.location.X - squareSize, square2.location.Y + squareSize);
                    break;
                case RotateDirections.East:
                    myRotation = RotateDirections.North;
                    square1.location = new Point(square2.location.X - squareSize, square2.location.Y);
                    square3.location = new Point(square2.location.X, square2.location.Y + squareSize);
                    square4.location = new Point(square2.location.X + squareSize, square2.location.Y + squareSize);
                    break;
            }
            //旋转之后检测位置是否冲突
            if (!(GameField.isEmpty(square1.location.X / squareSize, square1.location.Y / squareSize) &&
                GameField.isEmpty(square2.location.X / squareSize, square2.location.Y / squareSize) &&
                GameField.isEmpty(square3.location.X / squareSize, square3.location.Y / squareSize) &&
                GameField.isEmpty(square4.location.X / squareSize, square4.location.Y / squareSize)))
            {//如果有冲突则回到原来的状态
                myRotation = oldRotation;
                square1.location = oldPosition1;
                square2.location = oldPosition2;
                square3.location = oldPosition3;
                square4.location = oldPosition4;
            }
            Draw(GameField.winHandle);
        }
    }
}
