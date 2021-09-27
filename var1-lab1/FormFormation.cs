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
    public partial class FormFormation : Form
    {
        private readonly Formation<Plane> formation;
        public FormFormation()
        {
            InitializeComponent();
            formation = new Formation<Plane>(pictureBoxFormation.Width,
            pictureBoxFormation.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxFormation.Width, pictureBoxFormation.Height);
            Graphics gr = Graphics.FromImage(bmp);
            formation.Draw(gr);
            pictureBoxFormation.Image = bmp;
        }

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)

            {
                var plane = new Plane(100, 1000, dialog.Color);
                int  num = formation + plane;
                if (num != -1)
                {
                    MessageBox.Show("Место " + num + " заполнено");
                    Draw();
                }
                else
                {
                    MessageBox.Show("Построение заполнено");
                }
            }
        }

        private void buttonSetBomber_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Plane_bomber(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int num = formation + plane;
                    if (num != -1)
                    {
                        MessageBox.Show("Место " + num + " заполнено");
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Построение заполнено");
                    }
                }
            }
        }

        private void buttonUnsetPlane_Click(object sender, EventArgs e)
        {
            if (textBoxUnset.Text != "")
            {
                var plane = formation - Convert.ToInt32(textBoxUnset.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
