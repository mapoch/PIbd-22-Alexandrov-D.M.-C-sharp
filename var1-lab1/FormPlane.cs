using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace var1_lab1
{
    public partial class FormPlane : Form
    {
        private ITransport plane;

        public FormPlane()
        {
            InitializeComponent();
        }

        public void SetPlane(ITransport plane_new)
        {
            this.plane = plane_new;
            Draw();
        }

            private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plane?.DrawObject(gr);
            pictureBoxPlane.Image = bmp;
        }

        private void buttonCreateP_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plane = new Plane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width, pictureBoxPlane.Height);
            Draw();
        }

        private void buttonCreateB_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plane = new Plane_bomber(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green, Color.Red, true, true);
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width, pictureBoxPlane.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    plane?.MoveObject(Direction.Up);
                    break;
                case "buttonDown":
                    plane?.MoveObject(Direction.Down);
                    break;
                case "buttonRight":
                    plane?.MoveObject(Direction.Right);
                    break;
                case "buttonLeft":
                    plane?.MoveObject(Direction.Left);
                    break;
            }
            Draw();
        }

        
    }
}
