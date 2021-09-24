using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace var1_lab1
{
    public class Plane : Vehicle
    {
        protected readonly int planeWidth = 95;
        protected readonly int planeHeight = 70;

        public Plane(int maxSpeed, int load_Weight, Color mainColor)
        {
            Max_Speed = maxSpeed;
            Load_Weight = load_Weight;
            MainColor = mainColor;
        }

        protected Plane(int maxSpeed, int load_Weight, Color mainColor, int plane_Width, int plane_Height)
        {
            Max_Speed = maxSpeed;
            Load_Weight = load_Weight;
            MainColor = mainColor;
            this.planeWidth = plane_Width;
            this.planeHeight = plane_Height;
        }

        public override void MoveObject(Direction direction)
        {
            int step = Max_Speed * 100 / Load_Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startX + step < _picWidth - planeWidth)
                    {
                        _startX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startX - step > 0)
                    {
                        _startX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startY - step > 0)
                    {
                        _startY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startY + step < _picHeight - planeHeight)
                    {
                        _startY += step;
                    }
                    break;
            }
        }

        public override void DrawObject(Graphics g)
        {
            Pen penM = new Pen(MainColor);

            Point[] cabin = { new Point(_startX, _startY + 35), new Point(_startX + 15, _startY + 30),
                new Point(_startX + 15, _startY + 40) };

            g.FillPolygon(new SolidBrush(MainColor), cabin);

            Point[] wings = { new Point(_startX + 40, _startY + 0), new Point(_startX + 45, _startY + 0),
                new Point(_startX + 55, _startY + 25), new Point(_startX + 55, _startY + 45), new Point(_startX + 45, _startY + 70),
                new Point(_startX + 40, _startY + 70)};

            Point[] tail = { new Point(_startX + 90, _startY + 20), new Point(_startX + 95, _startY + 15),
                new Point(_startX + 95, _startY + 55), new Point(_startX + 90, _startY + 50) };

            Point[] body = { new Point(_startX + 15, _startY + 30), new Point(_startX + 15, _startY + 40),
                new Point(_startX + 95, _startY + 40), new Point(_startX + 95, _startY + 30) };

            g.DrawPolygon(penM, wings);

            g.DrawPolygon(penM, tail);

            g.DrawPolygon(penM, body);
        }
    }
}
