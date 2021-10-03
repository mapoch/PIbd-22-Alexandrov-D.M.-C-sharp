using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_lab1
{
    class Plane_bomber
    {
        private int _startX;
        private int _startY;

        private int _picWidth;
        private int _picHeight;

        private readonly int planeWidth = 105;
        private readonly int planeHeight = 70;

        public int Load_Weight { private set; get; }
        public int Max_Speed { private set; get; }

        public Color MainColor { private set; get; }
        public Color AddColor { private set; get; }

        public bool Bombs_state { private set; get; }
        public bool Back_state { private set; get; }

        public void Init(int max_Speed, int load_Weight, Color mainColor, Color addColor,
            bool bombs_state, bool back_state)
        {
            Max_Speed = max_Speed;
            Load_Weight = load_Weight;
            MainColor = mainColor;
            AddColor = addColor;
            Bombs_state = bombs_state;
            Back_state = back_state;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startX = x;
            _startY = y;

            _picHeight = height;
            _picWidth = width;
        }

        public void MoveObject(Direction dir)
        {
            int step = Max_Speed * 100 / Load_Weight;
            switch (dir)
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

        public void DrawObject(Graphics g)
        {
            Pen penM = new Pen(MainColor);

            Pen penA = new Pen(AddColor);

            Brush brushA = new SolidBrush(AddColor);

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

            if (Back_state)
            {
                g.DrawEllipse(penA, new Rectangle(_startX + 90, _startY + 30, 10, 10));
                g.DrawLine(penA, new Point(_startX + 100, _startY + 35), new Point(_startX + 105, _startY + 35));
            }

            if (Bombs_state)
            {
                Rectangle[] bomb = { new Rectangle(_startX + 30, _startY + 31, 10, 8),
                    new Rectangle(_startX + 50, _startY + 31, 10, 8) };

                Point[] bomb_plumage_1 = { new Point(_startX + 40, _startY + 35), new Point(_startX + 45, _startY + 31),
                    new Point(_startX + 45, _startY + 39)};
                Point[] bomb_plumage_2 = { new Point(_startX + 60, _startY + 35), new Point(_startX + 65, _startY + 31),
                    new Point(_startX + 65, _startY + 39)};

                g.FillEllipse(brushA, bomb[0]);
                g.FillEllipse(brushA, bomb[1]);

                g.FillPolygon(brushA, bomb_plumage_1);
                g.FillPolygon(brushA, bomb_plumage_2);
            }
        }
    }
}
