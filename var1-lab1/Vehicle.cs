using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace var1_lab1
{
    public abstract class Vehicle : ITransport
    {
        protected int _startX;
        protected int _startY;

        protected int _picWidth;
        protected int _picHeight;

        public int Max_Speed { protected set; get; }
        public int Load_Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startX = x;
            _startY = y;

            _picHeight = height;
            _picWidth = width;
        }
        public abstract void DrawObject(Graphics g);
        public abstract void MoveObject(Direction direction);

        public void SetMainColor(Color color) 
        {
            MainColor = color;
        }

        public void SetMaxSpeed(int value)
        {
            Max_Speed = value;
        }

        public void SetLoadWeight(int value)
        {
            Load_Weight = value;
        }
    }
}
