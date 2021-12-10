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

        public Plane_bomber(int max_Speed, int load_Weight, Color mainColor, Color addColor, bool bombs_state, bool back_state) :
            base(max_Speed, load_Weight, mainColor, 105, 70)
        {
            AddColor = addColor;
            Bombs_state = bombs_state;
            Back_state = back_state;
        }

        public Plane_bomber(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                Max_Speed = Convert.ToInt32(strs[0]);
                Load_Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                AddColor = Color.FromName(strs[3]);
                Back_state = Convert.ToBoolean(strs[4]);
                Bombs_state = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawObject(Graphics g)
        {
            base.DrawObject(g);

            Pen penA = new Pen(AddColor);

            Brush brushA = new SolidBrush(AddColor);

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

        public void SetAddColor (Color color) 
        {
            AddColor = color;
        }

        public void SetCabinState(bool state)
        {
            Back_state = state;
        }

        public void SetBombsState(bool state)
        {
            Bombs_state = state;
        }

        public override string ToString()
        {
            return $"{Max_Speed}{separator}{Load_Weight}{separator}{MainColor.Name}" +
                $"{separator}{AddColor.Name}{separator}{Back_state}{separator}{Bombs_state}";
        }

        public bool Equals(Plane_bomber other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (Max_Speed != other.Max_Speed)
            {
                return false;
            }
            if (Load_Weight != other.Load_Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (AddColor != other.AddColor)
            {
                return false;
            }
            if (Back_state != other.Back_state)
            {
                return false;
            }
            if (Bombs_state != other.Bombs_state)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Plane_bomber planebObj))
            {
                return false;
            }
            else
            {
                return Equals(planebObj);
            }
        }
    }
}
