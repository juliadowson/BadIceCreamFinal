using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BadIceCreamFinal
{
    class Player
    {
        public int x, y, width, height, speed;
        public Color colour;

        public Player(int _x, int _y, int _width, int _height, int _speed, Color _colour)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            colour = _colour;
        }

        public void Move(bool left, bool right, bool up, bool down, List<Rectangle> walls)
        {
            if(left && Collision(walls, x - 10, y + height /2))
            {
                x -= speed;               
            }
            else if (right && Collision(walls, x + width, y + height / 2))
            {
                x += speed;
            }
            else if (up && Collision(walls, x + width / 2, y +2))
            {
                y -= speed;
            }
            else if (down && Collision(walls, x + width / 2, y + height + 3))
            {
                y += speed;
            }
        }

        public bool Collision(List<Rectangle> walls, int x, int y)
        {
            foreach (Rectangle rec in walls)
            {
                if (rec.Contains(x, y)) { return false; }
            }
            return true;
        }

        public bool PointCollision(Points p)
        {
            Rectangle pointsRec = new Rectangle(p.x, p.y, p.width, p.height);
            Rectangle futurePlayerRec = new Rectangle(x + speed, y + speed, width, height);

            if(pointsRec.IntersectsWith(futurePlayerRec))
            {
                return true;
            }
            return false;
        }
    }
}
