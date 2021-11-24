using NLog;
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
        private readonly Logger logger;

        public FormHangar()
        {
            InitializeComponent();
            hangarsCollection = new HangarsCollection(pictureBoxHangar.Width,
            pictureBoxHangar.Height);
            Draw();
            logger = LogManager.GetCurrentClassLogger();
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
                var planeConfForm = new FormPlaneConfig();
                planeConfForm.AddEvent(AddPlane);
                planeConfForm.Show();
            }
        }

        private void buttonUnsetPlane_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1 && textBoxUnset.Text != "")
            {
                try
                {
                    var plane = hangarsCollection[listBoxHangars.SelectedItem.ToString()] - Convert.ToInt32(textBoxUnset.Text);
                    if (plane != null)
                    {
                        FormPlane form = new FormPlane();
                        form.SetPlane(plane);
                        form.ShowDialog();
                        logger.Info($"Изъят самолёт {plane} с места {textBoxUnset.Text}");
                        Draw();
                    }
                }
                catch (HangarNotFoundException ex)
                {
                    logger.Warn("Ошибка отсутствия самолёта при попытке удалить самолёт");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при попытке удалить самолёт");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonAddHangar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHangarName.Text))
            {
                MessageBox.Show("Введите название ангара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили ангар {textBoxHangarName.Text}");
            hangarsCollection.AddHangar(textBoxHangarName.Text);
            ReloadLevels();
        }

        private void buttonDeleteHangar_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить ангар { listBoxHangars.SelectedItem.ToString()}?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили ангар {listBoxHangars.SelectedItem.ToString()}");
                    hangarsCollection.DelHangar(listBoxHangars.SelectedItem.ToString());
                    ReloadLevels();
                }
                Draw();
            }
        }

        private void listBoxHangars_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на ангар {listBoxHangars.SelectedItem.ToString()}");
            Draw();
        }

        private void AddPlane(Vehicle plane)
        {
            if (plane != null && listBoxHangars.SelectedIndex > -1)
            {
                try
                {
                    if (hangarsCollection[listBoxHangars.SelectedItem.ToString()] + plane > -1)
                    {
                        Draw();
                        logger.Info($"Добавлен самолёт {plane}");
                    }
                    else
                    {
                        MessageBox.Show("Самолёт не удалось разместить");
                    }
                    Draw();
                }
                catch (HangarOverflowException ex)
                {
                    logger.Warn("Ошибка переполнения ангара при попытке добавить самолёт");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при попытке добавить самолёт");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarsCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при попытке сохранения");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarsCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при попытке загрузки");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
