using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDemo
{
    internal class BlockJ:Block
    {
        public BlockJ(Point thisLocation)
        {
            blockType = BlockTypes.J;
            foreColor = GameField.BlockForeColor[2];
            backColor = GameField.BlockBackColor[2];
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, foreColor, backColor);
            square2 = new Square(squareS, foreColor, backColor);
            square3 = new Square(squareS, foreColor, backColor);
            square4 = new Square(squareS, foreColor, backColor);
            square1.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
            square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
            square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y + 2 * squareSize);
            square4.location = new Point(thisLocation.X, thisLocation.Y + 2 * squareSize);
        }

        public BlockJ(Point thisLocation, Color fc, Color bc)
        {
            blockType = BlockTypes.J;
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, fc, bc);
            square2 = new Square(squareS, fc, bc);
            square3 = new Square(squareS, fc, bc);
            square4 = new Square(squareS, fc, bc);
            square1.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
            square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
            square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y + 2 * squareSize);
            square4.location = new Point(thisLocation.X, thisLocation.Y + 2 * squareSize);
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
                    square1.location = new Point(square3.location.X + 2 * squareSize, square3.location.Y);
                    square2.location = new Point(square3.location.X + squareSize, square3.location.Y);
                    square4.location = new Point(square3.location.X, square3.location.Y - squareSize);
                    break;
                case RotateDirections.East:
                    myRotation = RotateDirections.South;
                    square1.location = new Point(square3.location.X, square3.location.Y + 2 * squareSize);
                    square2.location = new Point(square3.location.X, square3.location.Y + squareSize);
                    square4.location = new Point(square3.location.X + squareSize, square3.location.Y);
                    break;
                case RotateDirections.South:
                    myRotation = RotateDirections.West;
                    square1.location = new Point(square3.location.X - 2 * squareSize, square3.location.Y);
                    square2.location = new Point(square3.location.X - squareSize, square3.location.Y);
                    square4.location = new Point(square3.location.X, square3.location.Y + squareSize);
                    break;
                case RotateDirections.West:
                    myRotation = RotateDirections.North;
                    square1.location = new Point(square3.location.X, square3.location.Y - 2 * squareSize);
                    square2.location = new Point(square3.location.X, square3.location.Y - squareSize);
                    square4.location = new Point(square3.location.X - squareSize, square3.location.Y);
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
