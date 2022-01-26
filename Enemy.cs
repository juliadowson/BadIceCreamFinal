using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BadIceCreamFinal
{
    public class Enemy
    {
        public int width, height, x, y;
        public Color colour;
        public int speed;
        public string lastDirection = "up";

        public static Random rand = new Random();

        public Enemy(int _x, int _y, int _width, int _height, int _speed, Color _colour)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            colour = _colour;
        }

        public void Move(List<Rectangle> walls)
        {
            if (lastDirection == "up" && !collision(walls, x + width / 2, y))
            {
                y -= speed;                      
            }
            else if (lastDirection == "up" && collision(walls, x + width / 2, y))
            {
                lastDirection = "down";
            }
            
            else if (lastDirection == "down" && !collision(walls, x + width / 2, y + height))
            {
                y += speed;               
            }
            else if (lastDirection == "down" && collision(walls, x + width / 2, y + height))
            {
                lastDirection = "up";
            }
        }


        public bool collision(List<Rectangle> walls, int x, int y)
        {
            foreach (Rectangle rec in walls)
            {
                if (rec.Contains(x, y)) { return true; }
            }
            return false;
        }

    }
}
