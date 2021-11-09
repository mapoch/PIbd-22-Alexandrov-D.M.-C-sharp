
namespace var1_lab1
{
    partial class FormPlaneConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxBombs = new System.Windows.Forms.CheckBox();
            this.checkBoxCabin = new System.Windows.Forms.CheckBox();
            this.numericUpDownLoad = new System.Windows.Forms.NumericUpDown();
            this.labelLoad = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelBomber = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelAddColor = new System.Windows.Forms.Label();
            this.panelOrangeColor = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelBlackColor = new System.Windows.Forms.Panel();
            this.panelGreyColor = new System.Windows.Forms.Panel();
            this.panelWhiteColor = new System.Windows.Forms.Panel();
            this.panelYellowColor = new System.Windows.Forms.Panel();
            this.panelBlueColor = new System.Windows.Forms.Panel();
            this.panelGreenColor = new System.Windows.Forms.Panel();
            this.panelRedColor = new System.Windows.Forms.Panel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.panelPlane.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxParameters.Controls.Add(this.checkBoxBombs);
            this.groupBoxParameters.Controls.Add(this.checkBoxCabin);
            this.groupBoxParameters.Controls.Add(this.numericUpDownLoad);
            this.groupBoxParameters.Controls.Add(this.labelLoad);
            this.groupBoxParameters.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParameters.Controls.Add(this.labelSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 244);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(501, 147);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxBombs
            // 
            this.checkBoxBombs.AutoSize = true;
            this.checkBoxBombs.Checked = true;
            this.checkBoxBombs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBombs.Location = new System.Drawing.Point(313, 77);
            this.checkBoxBombs.Name = "checkBoxBombs";
            this.checkBoxBombs.Size = new System.Drawing.Size(74, 21);
            this.checkBoxBombs.TabIndex = 5;
            this.checkBoxBombs.Text = "Бомбы";
            this.checkBoxBombs.UseVisualStyleBackColor = true;
            this.checkBoxBombs.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCabin
            // 
            this.checkBoxCabin.AutoSize = true;
            this.checkBoxCabin.Checked = true;
            this.checkBoxCabin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCabin.Location = new System.Drawing.Point(313, 50);
            this.checkBoxCabin.Name = "checkBoxCabin";
            this.checkBoxCabin.Size = new System.Drawing.Size(167, 21);
            this.checkBoxCabin.TabIndex = 4;
            this.checkBoxCabin.Text = "Кабина бортстрелка";
            this.checkBoxCabin.UseVisualStyleBackColor = true;
            this.checkBoxCabin.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // numericUpDownLoad
            // 
            this.numericUpDownLoad.Location = new System.Drawing.Point(131, 113);
            this.numericUpDownLoad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLoad.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownLoad.Name = "numericUpDownLoad";
            this.numericUpDownLoad.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLoad.TabIndex = 3;
            this.numericUpDownLoad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownLoad.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(13, 113);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(97, 17);
            this.labelLoad.TabIndex = 2;
            this.labelLoad.Text = "Вес загрузки:";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(131, 49);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSpeed.TabIndex = 1;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(13, 49);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(112, 17);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Макс. скорость:";
            // 
            // groupBoxType
            // 
            this.groupBoxType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxType.Controls.Add(this.labelBomber);
            this.groupBoxType.Controls.Add(this.labelPlane);
            this.groupBoxType.Location = new System.Drawing.Point(12, 29);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(200, 195);
            this.groupBoxType.TabIndex = 1;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип";
            // 
            // labelBomber
            // 
            this.labelBomber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBomber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBomber.Location = new System.Drawing.Point(6, 119);
            this.labelBomber.Name = "labelBomber";
            this.labelBomber.Size = new System.Drawing.Size(188, 61);
            this.labelBomber.TabIndex = 1;
            this.labelBomber.Text = "Бомбардировщик";
            this.labelBomber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBomber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBomber_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(6, 42);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(188, 61);
            this.labelPlane.TabIndex = 0;
            this.labelPlane.Text = "Военный самолёт";
            this.labelPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxPlane.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(273, 189);
            this.pictureBoxPlane.TabIndex = 2;
            this.pictureBoxPlane.TabStop = false;
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(234, 29);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(279, 195);
            this.panelPlane.TabIndex = 3;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxColors.Controls.Add(this.labelAddColor);
            this.groupBoxColors.Controls.Add(this.panelOrangeColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelBlackColor);
            this.groupBoxColors.Controls.Add(this.panelGreyColor);
            this.groupBoxColors.Controls.Add(this.panelWhiteColor);
            this.groupBoxColors.Controls.Add(this.panelYellowColor);
            this.groupBoxColors.Controls.Add(this.panelBlueColor);
            this.groupBoxColors.Controls.Add(this.panelGreenColor);
            this.groupBoxColors.Controls.Add(this.panelRedColor);
            this.groupBoxColors.Location = new System.Drawing.Point(540, 29);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(257, 222);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelAddColor
            // 
            this.labelAddColor.AllowDrop = true;
            this.labelAddColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAddColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAddColor.Location = new System.Drawing.Point(130, 27);
            this.labelAddColor.Name = "labelAddColor";
            this.labelAddColor.Size = new System.Drawing.Size(116, 50);
            this.labelAddColor.TabIndex = 9;
            this.labelAddColor.Text = "Доп. цвет";
            this.labelAddColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAddColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelAddColor_DragDrop);
            this.labelAddColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // panelOrangeColor
            // 
            this.panelOrangeColor.BackColor = System.Drawing.Color.Orange;
            this.panelOrangeColor.Location = new System.Drawing.Point(191, 161);
            this.panelOrangeColor.Name = "panelOrangeColor";
            this.panelOrangeColor.Size = new System.Drawing.Size(55, 55);
            this.panelOrangeColor.TabIndex = 8;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(8, 27);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(116, 50);
            this.labelMainColor.TabIndex = 7;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // panelBlackColor
            // 
            this.panelBlackColor.BackColor = System.Drawing.Color.Black;
            this.panelBlackColor.Location = new System.Drawing.Point(69, 161);
            this.panelBlackColor.Name = "panelBlackColor";
            this.panelBlackColor.Size = new System.Drawing.Size(55, 55);
            this.panelBlackColor.TabIndex = 6;
            // 
            // panelGreyColor
            // 
            this.panelGreyColor.BackColor = System.Drawing.Color.Gray;
            this.panelGreyColor.Location = new System.Drawing.Point(130, 161);
            this.panelGreyColor.Name = "panelGreyColor";
            this.panelGreyColor.Size = new System.Drawing.Size(55, 55);
            this.panelGreyColor.TabIndex = 5;
            // 
            // panelWhiteColor
            // 
            this.panelWhiteColor.BackColor = System.Drawing.Color.White;
            this.panelWhiteColor.Location = new System.Drawing.Point(8, 161);
            this.panelWhiteColor.Name = "panelWhiteColor";
            this.panelWhiteColor.Size = new System.Drawing.Size(55, 55);
            this.panelWhiteColor.TabIndex = 4;
            // 
            // panelYellowColor
            // 
            this.panelYellowColor.BackColor = System.Drawing.Color.Yellow;
            this.panelYellowColor.Location = new System.Drawing.Point(191, 100);
            this.panelYellowColor.Name = "panelYellowColor";
            this.panelYellowColor.Size = new System.Drawing.Size(55, 55);
            this.panelYellowColor.TabIndex = 3;
            // 
            // panelBlueColor
            // 
            this.panelBlueColor.BackColor = System.Drawing.Color.Blue;
            this.panelBlueColor.Location = new System.Drawing.Point(130, 100);
            this.panelBlueColor.Name = "panelBlueColor";
            this.panelBlueColor.Size = new System.Drawing.Size(55, 55);
            this.panelBlueColor.TabIndex = 2;
            // 
            // panelGreenColor
            // 
            this.panelGreenColor.BackColor = System.Drawing.Color.Green;
            this.panelGreenColor.Location = new System.Drawing.Point(69, 100);
            this.panelGreenColor.Name = "panelGreenColor";
            this.panelGreenColor.Size = new System.Drawing.Size(55, 55);
            this.panelGreenColor.TabIndex = 1;
            // 
            // panelRedColor
            // 
            this.panelRedColor.BackColor = System.Drawing.Color.Red;
            this.panelRedColor.Location = new System.Drawing.Point(8, 100);
            this.panelRedColor.Name = "panelRedColor";
            this.panelRedColor.Size = new System.Drawing.Size(55, 55);
            this.panelRedColor.TabIndex = 0;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(540, 275);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(257, 52);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Добавить";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(540, 339);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(257, 52);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 403);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormPlaneConfig";
            this.Text = "Plane configs";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.panelPlane.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox checkBoxBombs;
        private System.Windows.Forms.CheckBox checkBoxCabin;
        private System.Windows.Forms.NumericUpDown numericUpDownLoad;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelBomber;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelBlackColor;
        private System.Windows.Forms.Panel panelGreyColor;
        private System.Windows.Forms.Panel panelWhiteColor;
        private System.Windows.Forms.Panel panelYellowColor;
        private System.Windows.Forms.Panel panelBlueColor;
        private System.Windows.Forms.Panel panelGreenColor;
        private System.Windows.Forms.Panel panelRedColor;
        private System.Windows.Forms.Label labelAddColor;
        private System.Windows.Forms.Panel panelOrangeColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonCancel;
    }
}