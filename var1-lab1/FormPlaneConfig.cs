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
    public partial class FormPlaneConfig : Form
    {
        Vehicle plane = null;

        private event Action<Vehicle> eventAddPlane;

        public FormPlaneConfig()
        {
            InitializeComponent();

            panelBlackColor.MouseDown += this.panelColor_MouseDown;
            panelGreyColor.MouseDown += this.panelColor_MouseDown;
            panelWhiteColor.MouseDown += this.panelColor_MouseDown;
            panelYellowColor.MouseDown += this.panelColor_MouseDown;
            panelOrangeColor.MouseDown += this.panelColor_MouseDown;
            panelRedColor.MouseDown += this.panelColor_MouseDown;
            panelBlueColor.MouseDown += this.panelColor_MouseDown;
            panelGreenColor.MouseDown += this.panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawObject(gr);
                pictureBoxPlane.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = ev;
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBomber_MouseDown(object sender, MouseEventArgs e)
        {
            labelBomber.DoDragDrop(labelBomber.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Военный самолёт":
                    plane = new Plane(100, 500, Color.Black);
                    break;
                case "Бомбардировщик":
                    plane = new Plane_bomber(100, 500, Color.Black, Color.Black, true, true);
                    break;
            }
            DrawPlane();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                (plane as Plane).SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        private void labelAddColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null && (plane is Plane_bomber))
            {
                (plane as Plane_bomber).SetAddColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (plane is Plane_bomber)
            {
                if (checkBoxCabin.Checked)
                {
                    (plane as Plane_bomber).SetCabinState(true);
                }
                else
                {
                    (plane as Plane_bomber).SetCabinState(false);
                }
                if (checkBoxBombs.Checked)
                {
                    (plane as Plane_bomber).SetBombsState(true);
                }
                else
                {
                    (plane as Plane_bomber).SetBombsState(false);
                }
                DrawPlane();
            }
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSpeed.Value > 0)
            {
                plane.SetMaxSpeed((int) numericUpDownSpeed.Value);
            }
            if (numericUpDownLoad.Value > 0)
            {
                plane.SetLoadWeight((int)numericUpDownLoad.Value);
            }
            DrawPlane();
        }
    }
}
