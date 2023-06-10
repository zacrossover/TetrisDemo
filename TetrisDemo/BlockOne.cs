using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDemo
{
    internal class BlockOne:Block
    {
        Size zeroSize = new Size(0,0);
        public BlockOne(Point thisLocation)
        {
            blockType = BlockTypes.One;
            foreColor = GameField.BlockForeColor[7];
            backColor = GameField.BlockBackColor[7];
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, foreColor, backColor);
            square2 = new Square(squareS, foreColor, backColor);
            square3 = new Square(squareS, foreColor, backColor);
            square4 = new Square(squareS, foreColor, backColor);
            square1.location = new Point(thisLocation.X, thisLocation.Y);
            square2.location = square1.location;
            square3.location = square1.location;
            square4.location = square1.location;
        }

        public BlockOne(Point thisLocation, Color fc, Color bc)
        {
            blockType = BlockTypes.One;
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, fc, bc);
            square2 = new Square(squareS, fc, bc);
            square3 = new Square(squareS, fc, bc);
            square4 = new Square(squareS, fc, bc);
            square1.location = new Point(thisLocation.X, thisLocation.Y);
            square2.location = square1.location;
            square3.location = square1.location;
            square4.location = square1.location;
        }

        public override void Rotate()
        {

        }

        public override bool down()
        {
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
            else 
            {
                for(int i = square1.location.Y / squareSize + 1; i < 30; i++)
                {
                    if (GameField.isEmpty(square1.location.X / squareSize, i))
                    {
                        Erase(GameField.winHandle);
                        square1.location = new Point(square1.location.X, i * squareSize);
                        square2.location = new Point(square2.location.X, i * squareSize);
                        square3.location = new Point(square3.location.X, i * squareSize);
                        square4.location = new Point(square4.location.X, i * squareSize);
                        Draw(GameField.winHandle);
                        return true;
                    }
                }

                GameField.stopSquare(square1, square1.location.X / squareSize, square1.location.Y / squareSize);
                GameField.stopSquare(square2, square2.location.X / squareSize, square2.location.Y / squareSize);
                GameField.stopSquare(square3, square3.location.X / squareSize, square3.location.Y / squareSize);
                GameField.stopSquare(square4, square4.location.X / squareSize, square4.location.Y / squareSize);
                return false; //表示可以弹出下一个block了
            }
     
        }
    }
}
