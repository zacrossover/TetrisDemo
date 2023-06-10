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
            blockType = BlockTypes.line;
            foreColor = GameField.BlockForeColor[1];
            backColor = GameField.BlockBackColor[1];
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, foreColor, backColor);
            square2 = new Square(zeroSize, foreColor, backColor);
            square3 = new Square(zeroSize, foreColor, backColor);
            square4 = new Square(zeroSize, foreColor, backColor);
            square1.location = new Point(thisLocation.X, thisLocation.Y);
            square2.location = square1.location;
            square3.location = square1.location;
            square4.location = square1.location;
        }

        public BlockOne(Point thisLocation, Color fc, Color bc)
        {
            blockType = BlockTypes.line;
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, fc, bc);
            square2 = new Square(zeroSize, fc, bc);
            square3 = new Square(zeroSize, fc, bc);
            square4 = new Square(zeroSize, fc, bc);
            square1.location = new Point(thisLocation.X, thisLocation.Y);
            square2.location = square1.location;
            square3.location = square1.location;
            square4.location = square1.location;
        }

        public override void Rotate()
        {

        }
    }
}
