using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TetrisDemo.Block;

namespace TetrisDemo
{
    internal class BlockO:Block
    {
        public BlockO(Point thisLocation)
        {
            foreColor = GameField.BlockForeColor[0];
            backColor = GameField.BlockBackColor[0];
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, foreColor, backColor);
            square2 = new Square(squareS, foreColor, backColor);
            square3 = new Square(squareS, foreColor, backColor);
            square4 = new Square(squareS, foreColor, backColor);
            square1.location = new Point(thisLocation.X, thisLocation.Y);
            square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
            square3.location = new Point(thisLocation.X, thisLocation.Y + squareSize);
            square4.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
        }

        public BlockO(Point thisLocation, Color fc, Color bc)
        {
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, fc, bc);
            square2 = new Square(squareS, fc, bc);
            square3 = new Square(squareS, fc, bc);
            square4 = new Square(squareS, fc, bc);
            square1.location = new Point(thisLocation.X, thisLocation.Y);
            square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
            square3.location = new Point(thisLocation.X, thisLocation.Y + squareSize);
            square4.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
        }

        public override void Rotate()
        {
 
        }
    }
}
