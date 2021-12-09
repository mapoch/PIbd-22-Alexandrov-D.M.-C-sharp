using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace var1_lab1
{
    class Hangar<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
    {
        private readonly List<T> _places;
        private readonly int _maxCount;

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 80;

        private int width;
        private int height;

        private int currentIndex;

        public T Current => _places[currentIndex];

        object IEnumerator.Current => _places[currentIndex];

        public Hangar(int picWidth, int picHeight)
        {
            width = picWidth / _placeSizeWidth;
            height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            currentIndex = -1;
        }

        public static int operator +(Hangar<T> f, T plane)
        {
            if (f._places.Count >= f._maxCount)
            {
                throw new HangarOverflowException();
            }
            if (f._places.Contains(plane))
            {
                throw new HangarAlreadyHaveException();
            }

            int i = 0;
            int j = 0;
            while (i < f.height)
            {
                j = 0;
                while (j < f.width)
                {
                    if (i * f.width + j == f._places.Count && f._places.Count <= f._maxCount)
                    {
                        f._places.Add(plane);
                        return (i * f.width + j);
                    }
                    else
                    if (i * f.width + j < f._places.Count && f._places[i * f.width + j] == null)
                    {
                        f._places[i * f.width + j] = plane;
                        return (i * f.width + j);
                    }
                    j++;
                }
                i++;
            }

            return -1;
        }

        public static T operator -(Hangar<T> f, int index)
        {
            if (index < 0 || index > f._places.Count)
            {
                throw new HangarNotFoundException(index);
            }

            if (index >= f._places.Count || index < 0) return null;
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
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i]?.SetPosition(5 + (i % width) * _placeSizeWidth, 5 + (i / width) * _placeSizeHeight, pictureWidth, pictureHeight);
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

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }

            return _places[index];
        }

        public void Sort() => _places.Sort((IComparer<T>)new PlaneComparer());

        public void Dispose() { }

        public bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < _places.Count());
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
