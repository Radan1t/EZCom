﻿namespace EZCom.Forms.Meet
{
    partial class FormChoose
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
            label1 = new Label();
            unit = new Button();
            custom = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F);
            label1.Location = new Point(47, 49);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Оберіть тип зустрічі";
            // 
            // unit
            // 
            unit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            unit.Location = new Point(47, 115);
            unit.Name = "unit";
            unit.Size = new Size(88, 36);
            unit.TabIndex = 1;
            unit.Text = "Підрозділи";
            unit.UseVisualStyleBackColor = true;
            unit.Click += unit_Click;
            // 
            // custom
            // 
            custom.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            custom.Location = new Point(171, 115);
            custom.Name = "custom";
            custom.Size = new Size(87, 36);
            custom.TabIndex = 2;
            custom.Text = "Власна";
            custom.UseVisualStyleBackColor = true;
            custom.Click += custom_Click;
            // 
            // FormChoose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(322, 213);
            Controls.Add(custom);
            Controls.Add(unit);
            Controls.Add(label1);
            Name = "FormChoose";
            Text = "FormChoose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button unit;
        private Button custom;
    }
}