using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace var1_lab1
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        
        void MoveObject(Direction direction);
        
        void DrawObject(Graphics g);

        void SetMainColor(Color color);
    }
}
