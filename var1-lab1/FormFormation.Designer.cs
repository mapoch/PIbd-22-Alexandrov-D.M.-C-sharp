
namespace var1_lab1
{
    partial class FormFormation
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
            this.buttonSetBomber = new System.Windows.Forms.Button();
            this.groupUnset = new System.Windows.Forms.GroupBox();
            this.labelUnset = new System.Windows.Forms.Label();
            this.textBoxUnset = new System.Windows.Forms.TextBox();
            this.buttonUnset = new System.Windows.Forms.Button();
            this.pictureBoxFormation = new System.Windows.Forms.PictureBox();
            this.groupUnset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(906, 12);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(165, 47);
            this.buttonSetPlane.TabIndex = 1;
            this.buttonSetPlane.Text = "Встроить самолёт";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // buttonSetBomber
            // 
            this.buttonSetBomber.Location = new System.Drawing.Point(906, 81);
            this.buttonSetBomber.Name = "buttonSetBomber";
            this.buttonSetBomber.Size = new System.Drawing.Size(165, 47);
            this.buttonSetBomber.TabIndex = 2;
            this.buttonSetBomber.Text = "Встроить бомбардировщик";
            this.buttonSetBomber.UseVisualStyleBackColor = true;
            this.buttonSetBomber.Click += new System.EventHandler(this.buttonSetBomber_Click);
            // 
            // groupUnset
            // 
            this.groupUnset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupUnset.Controls.Add(this.buttonUnset);
            this.groupUnset.Controls.Add(this.textBoxUnset);
            this.groupUnset.Controls.Add(this.labelUnset);
            this.groupUnset.Location = new System.Drawing.Point(906, 171);
            this.groupUnset.Name = "groupUnset";
            this.groupUnset.Size = new System.Drawing.Size(165, 110);
            this.groupUnset.TabIndex = 3;
            this.groupUnset.TabStop = false;
            this.groupUnset.Text = "Выстроить самолёт";
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
            // textBoxUnset
            // 
            this.textBoxUnset.Location = new System.Drawing.Point(65, 33);
            this.textBoxUnset.Name = "textBoxUnset";
            this.textBoxUnset.Size = new System.Drawing.Size(94, 22);
            this.textBoxUnset.TabIndex = 1;
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
            // pictureBoxFormation
            // 
            this.pictureBoxFormation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxFormation.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFormation.Name = "pictureBoxFormation";
            this.pictureBoxFormation.Size = new System.Drawing.Size(900, 601);
            this.pictureBoxFormation.TabIndex = 0;
            this.pictureBoxFormation.TabStop = false;
            // 
            // FormFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 601);
            this.Controls.Add(this.groupUnset);
            this.Controls.Add(this.buttonSetBomber);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.pictureBoxFormation);
            this.Name = "FormFormation";
            this.Text = "Formation";
            this.groupUnset.ResumeLayout(false);
            this.groupUnset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFormation;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.Button buttonSetBomber;
        private System.Windows.Forms.GroupBox groupUnset;
        private System.Windows.Forms.Button buttonUnset;
        private System.Windows.Forms.TextBox textBoxUnset;
        private System.Windows.Forms.Label labelUnset;
    }
}