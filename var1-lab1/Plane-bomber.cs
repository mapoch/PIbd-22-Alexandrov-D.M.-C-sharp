using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_lab1
{
    class Plane_bomber : Plane
    {
       
        public Color AddColor { private set; get; }

        public bool Bombs_state { private set; get; }
        public bool Back_state { private set; get; }

        public Plane_bomber(int max_Speed, int load_Weight, Color mainColor, Color addColor,
            bool bombs_state, bool back_state) :
            base(max_Speed, load_Weight, mainColor, 105, 70)
        {
            AddColor = addColor;
            Bombs_state = bombs_state;
            Back_state = back_state;
        }

        public override void DrawObject(Graphics g)
        {
            base.DrawObject(g);

            Pen penA = new Pen(AddColor);

            Brush brushA = new SolidBrush(AddColor);

            if (Back_state == true)
            {
                g.DrawEllipse(penA, new Rectangle(_startX + 90, _startY + 30, 10, 10));
                g.DrawLine(penA, new Point(_startX + 100, _startY + 35), new Point(_startX + 105, _startY + 35));
            }

            if (Bombs_state == true)
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
