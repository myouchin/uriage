﻿namespace NouhinSyo
{
    partial class frmNegurosuNouhinsyoInput
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
            this.textBox2 = new Common.CustomTextBox();
            this.label2 = new Common.ItemHeadLabel();
            this.dateTimePicker1 = new Common.CustomDateTimePicker();
            this.label17 = new Common.ItemHeadLabel();
            this.textBox8 = new Common.CustomTextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.DownControl = null;
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox2.LeftControl = null;
            this.textBox2.Location = new System.Drawing.Point(358, 24);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightControl = null;
            this.textBox2.Size = new System.Drawing.Size(279, 27);
            this.textBox2.TabIndex = 59;
            this.textBox2.Text = "ＸＸＸＸＸＸＸＸＸＸＸＸＸＸＸＸＸＸ２０";
            this.textBox2.UpControl = null;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "件名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("MS UI Gothic", 15F);
            this.dateTimePicker1.CustomFormat = "MM月dd日";
            this.dateTimePicker1.DownControl = null;
            this.dateTimePicker1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.LeftControl = null;
            this.dateTimePicker1.Location = new System.Drawing.Point(636, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightControl = null;
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 27);
            this.dateTimePicker1.TabIndex = 85;
            this.dateTimePicker1.UpControl = null;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 31, 17, 37, 0, 0);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(636, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 24);
            this.label17.TabIndex = 84;
            this.label17.Text = "納品月日";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            this.textBox8.DownControl = null;
            this.textBox8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox8.LeftControl = null;
            this.textBox8.Location = new System.Drawing.Point(358, 24);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.RightControl = null;
            this.textBox8.Size = new System.Drawing.Size(279, 27);
            this.textBox8.TabIndex = 65;
            this.textBox8.Text = "ＸＸＸＸＸＸＸＸＸＸＸＸＸＸＸＸＸＸ２０";
            this.textBox8.UpControl = null;
            // 
            // frmNegurosuNouhinsyoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1269, 711);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "frmNegurosuNouhinsyoInput";
            this.Text = "ネグロス納品書";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.CustomTextBox textBox2;
        private Common.ItemHeadLabel label2;
        private Common.CustomDateTimePicker dateTimePicker1;
        private Common.ItemHeadLabel label17;
        private Common.CustomTextBox textBox8;
    }
}