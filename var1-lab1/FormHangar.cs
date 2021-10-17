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
    public partial class FormHangar : Form
    {
        private readonly HangarsCollection hangarsCollection;
        public FormHangar()
        {
            InitializeComponent();
            hangarsCollection = new HangarsCollection(pictureBoxHangar.Width,
            pictureBoxHangar.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxHangars.SelectedIndex;
            listBoxHangars.Items.Clear();
            for (int i = 0; i < hangarsCollection.Keys.Count; i++)
            {
                listBoxHangars.Items.Add(hangarsCollection.Keys[i]);
            }

            if (listBoxHangars.Items.Count > 0 && (index == -1 || index >= listBoxHangars.Items.Count))
            {
                listBoxHangars.SelectedIndex = 0;
            }
            else if (listBoxHangars.Items.Count > 0 && index > -1 && index < listBoxHangars.Items.Count)
            {
                listBoxHangars.SelectedIndex = index;
            }
            Draw();
        }

        private void Draw()
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangarsCollection[listBoxHangars.SelectedItem.ToString()].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
            else if (listBoxHangars.Items.Count == 0)
            {
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pictureBoxHangar.Image = bmp;
            }
        }

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Plane(100, 1000, dialog.Color);
                    int num = hangarsCollection[listBoxHangars.SelectedItem.ToString()] + plane;
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

        private void buttonSetBomber_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var plane = new Plane_bomber(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        int num = hangarsCollection[listBoxHangars.SelectedItem.ToString()] + plane;
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
        }

        private void buttonUnsetPlane_Click(object sender, EventArgs e)
        {
            if (textBoxUnset.Text != "")
            {
                var plane = hangarsCollection[listBoxHangars.SelectedItem.ToString()] - Convert.ToInt32(textBoxUnset.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonAddHangar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHangarName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hangarsCollection.AddParking(textBoxHangarName.Text);
            ReloadLevels();
        }

        private void buttonDeleteHangar_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить построение { listBoxHangars.SelectedItem.ToString()}?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hangarsCollection.DelParking(listBoxHangars.SelectedItem.ToString());
                    ReloadLevels();
                }
                Draw();
            }
        }

        private void listBoxHangars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
