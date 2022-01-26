using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BadIceCreamFinal
{
    public class Block
    {
        public int width;
        public int height;
        public Brush brush;
        public Pen borderPen;


        public int x;
        public int y;
        public string colour;

        public static Random rand = new Random();

        public Block()
        {

        }
    }
}
