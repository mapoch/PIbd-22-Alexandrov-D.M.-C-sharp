
namespace var1_lab1
{
    partial class FormHangar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.groupUnset = new System.Windows.Forms.GroupBox();
            this.buttonUnset = new System.Windows.Forms.Button();
            this.textBoxUnset = new System.Windows.Forms.TextBox();
            this.labelUnset = new System.Windows.Forms.Label();
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.groupHangar = new System.Windows.Forms.GroupBox();
            this.buttonDeleteHangar = new System.Windows.Forms.Button();
            this.listBoxHangars = new System.Windows.Forms.ListBox();
            this.buttonAddHangar = new System.Windows.Forms.Button();
            this.textBoxHangarName = new System.Windows.Forms.TextBox();
            this.labelHangarName = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupUnset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupHangar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(906, 401);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(165, 47);
            this.buttonSetPlane.TabIndex = 1;
            this.buttonSetPlane.Text = "Встроить самолёт";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // groupUnset
            // 
            this.groupUnset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupUnset.Controls.Add(this.buttonUnset);
            this.groupUnset.Controls.Add(this.textBoxUnset);
            this.groupUnset.Controls.Add(this.labelUnset);
            this.groupUnset.Location = new System.Drawing.Point(906, 468);
            this.groupUnset.Name = "groupUnset";
            this.groupUnset.Size = new System.Drawing.Size(165, 110);
            this.groupUnset.TabIndex = 3;
            this.groupUnset.TabStop = false;
            this.groupUnset.Text = "Выстроить самолёт";
            // 
            // buttonUnset
            // 
            this.buttonUnset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUnset.Location = new System.Drawing.Point(9, 71);
            this.buttonUnset.Name = "buttonUnset";
            this.buttonUnset.Size = new System.Drawing.Size(150, 33);
            this.buttonUnset.TabIndex = 2;
            this.buttonUnset.Text = "Выстроить";
            this.buttonUnset.UseVisualStyleBackColor = false;
            this.buttonUnset.Click += new System.EventHandler(this.buttonUnsetPlane_Click);
            // 
            // textBoxUnset
            // 
            this.textBoxUnset.Location = new System.Drawing.Point(65, 33);
            this.textBoxUnset.Name = "textBoxUnset";
            this.textBoxUnset.Size = new System.Drawing.Size(94, 22);
            this.textBoxUnset.TabIndex = 1;
            // 
            // labelUnset
            // 
            this.labelUnset.AutoSize = true;
            this.labelUnset.Location = new System.Drawing.Point(6, 36);
            this.labelUnset.Name = "labelUnset";
            this.labelUnset.Size = new System.Drawing.Size(53, 17);
            this.labelUnset.TabIndex = 0;
            this.labelUnset.Text = "Место:";
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxHangar.Location = new System.Drawing.Point(0, 31);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(900, 570);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // groupHangar
            // 
            this.groupHangar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupHangar.Controls.Add(this.buttonDeleteHangar);
            this.groupHangar.Controls.Add(this.listBoxHangars);
            this.groupHangar.Controls.Add(this.buttonAddHangar);
            this.groupHangar.Controls.Add(this.textBoxHangarName);
            this.groupHangar.Controls.Add(this.labelHangarName);
            this.groupHangar.Location = new System.Drawing.Point(906, 31);
            this.groupHangar.Name = "groupHangar";
            this.groupHangar.Size = new System.Drawing.Size(165, 291);
            this.groupHangar.TabIndex = 4;
            this.groupHangar.TabStop = false;
            this.groupHangar.Text = "Выбор построения";
            // 
            // buttonDeleteHangar
            // 
            this.buttonDeleteHangar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteHangar.Location = new System.Drawing.Point(9, 236);
            this.buttonDeleteHangar.Name = "buttonDeleteHangar";
            this.buttonDeleteHangar.Size = new System.Drawing.Size(150, 42);
            this.buttonDeleteHangar.TabIndex = 4;
            this.buttonDeleteHangar.Text = "Удалить ангар";
            this.buttonDeleteHangar.UseVisualStyleBackColor = false;
            this.buttonDeleteHangar.Click += new System.EventHandler(this.buttonDeleteHangar_Click);
            // 
            // listBoxHangars
            // 
            this.listBoxHangars.FormattingEnabled = true;
            this.listBoxHangars.ItemHeight = 16;
            this.listBoxHangars.Location = new System.Drawing.Point(9, 114);
            this.listBoxHangars.Name = "listBoxHangars";
            this.listBoxHangars.Size = new System.Drawing.Size(150, 116);
            this.listBoxHangars.TabIndex = 3;
            this.listBoxHangars.SelectedIndexChanged += new System.EventHandler(this.listBoxHangars_SelectedIndexChanged);
            // 
            // buttonAddHangar
            // 
            this.buttonAddHangar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddHangar.Location = new System.Drawing.Point(9, 66);
            this.buttonAddHangar.Name = "buttonAddHangar";
            this.buttonAddHangar.Size = new System.Drawing.Size(150, 42);
            this.buttonAddHangar.TabIndex = 2;
            this.buttonAddHangar.Text = "Добавить ангар";
            this.buttonAddHangar.UseVisualStyleBackColor = false;
            this.buttonAddHangar.Click += new System.EventHandler(this.buttonAddHangar_Click);
            // 
            // textBoxHangarName
            // 
            this.textBoxHangarName.Location = new System.Drawing.Point(9, 38);
            this.textBoxHangarName.Name = "textBoxHangarName";
            this.textBoxHangarName.Size = new System.Drawing.Size(150, 22);
            this.textBoxHangarName.TabIndex = 1;
            // 
            // labelHangarName
            // 
            this.labelHangarName.AutoSize = true;
            this.labelHangarName.Location = new System.Drawing.Point(6, 18);
            this.labelHangarName.Name = "labelHangarName";
            this.labelHangarName.Size = new System.Drawing.Size(76, 17);
            this.labelHangarName.TabIndex = 0;
            this.labelHangarName.Text = "Название:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 601);
            this.Controls.Add(this.groupHangar);
            this.Controls.Add(this.groupUnset);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.pictureBoxHangar);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormHangar";
            this.Text = "Hangar";
            this.groupUnset.ResumeLayout(false);
            this.groupUnset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupHangar.ResumeLayout(false);
            this.groupHangar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.GroupBox groupUnset;
        private System.Windows.Forms.Button buttonUnset;
        private System.Windows.Forms.TextBox textBoxUnset;
        private System.Windows.Forms.Label labelUnset;
        private System.Windows.Forms.GroupBox groupHangar;
        private System.Windows.Forms.Label labelHangarName;
        private System.Windows.Forms.Button buttonDeleteHangar;
        private System.Windows.Forms.ListBox listBoxHangars;
        private System.Windows.Forms.Button buttonAddHangar;
        private System.Windows.Forms.TextBox textBoxHangarName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}