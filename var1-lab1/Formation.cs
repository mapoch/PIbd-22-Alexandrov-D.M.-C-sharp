using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace var1_lab1
{
    class Formation<T> where T : class, ITransport
    {
        private readonly T[] _places;

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 80;

        private int width;
        private int height;

        public Formation(int picWidth, int picHeight)
        {
            width = picWidth / _placeSizeWidth;
            height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static int operator +(Formation<T> f, T plane)
        {
            int i = 0;
            int j = 0;

            while (i < f.height) 
            {
                j = 0;
                while (j < f.width)
                {
                    if (f._places[i*f.width + j] == null)
                    {
                        plane.SetPosition(5 + j * f._placeSizeWidth, 5 + i * f._placeSizeHeight, f.pictureWidth, f.pictureHeight);
                        f._places[i * f.width + j] = plane;
                        return (i * f.width + j);
                    }
                    j++;
                }
                i++;
            }
            return -1;
        }

        public static T operator -(Formation<T> f, int index)
        {
            if (index >= f._places.Length || index < 0) return null;
            if (f._places[index] != null)
            {
                T ret_T = f._places[index];
                f._places[index] = null;
                return ret_T;
            }
            else return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawObject(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                    _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
