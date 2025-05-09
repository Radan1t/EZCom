﻿namespace EZCom.Forms.Main
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            groupBox6 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            groupBox5 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            groupBox4 = new GroupBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBox7 = new GroupBox();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 616);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(183, 167, 174);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(59, 571);
            button1.Name = "button1";
            button1.Size = new Size(121, 39);
            button1.TabIndex = 3;
            button1.Text = "Новичй чат";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CreateChat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(84, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 2;
            label1.Text = "Чати";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(88, 84, 91);
            groupBox6.Controls.Add(flowLayoutPanel2);
            groupBox6.Controls.Add(label3);
            groupBox6.Location = new Point(6, 281);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(237, 284);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(6, 28);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(225, 250);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(78, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "Direct";
            label3.Click += label3_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(88, 84, 91);
            groupBox5.Controls.Add(flowLayoutPanel1);
            groupBox5.Controls.Add(label2);
            groupBox5.FlatStyle = FlatStyle.Popup;
            groupBox5.Location = new Point(6, 28);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(237, 247);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(6, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(225, 195);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(53, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 3;
            label2.Text = "Підрозділи";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(217, 217, 217);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(flowLayoutPanel3);
            groupBox3.Location = new Point(267, 346);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(482, 318);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(129, 4);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 4;
            label4.Text = "Заплановані зустрічі";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(6, 27);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(470, 290);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(217, 217, 217);
            groupBox4.Controls.Add(webView21);
            groupBox4.Location = new Point(267, 41);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(482, 305);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(6, 11);
            webView21.Name = "webView21";
            webView21.Size = new Size(470, 288);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(pictureBox1);
            groupBox7.Controls.Add(button5);
            groupBox7.Controls.Add(button4);
            groupBox7.Controls.Add(button3);
            groupBox7.Controls.Add(button2);
            groupBox7.Location = new Point(-1, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1016, 35);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.EZCom_logo_variant_removebg_preview;
            pictureBox1.Location = new Point(25, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(510, 6);
            button5.Name = "button5";
            button5.Size = new Size(70, 29);
            button5.TabIndex = 3;
            button5.Text = "Зустріч";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += MeetingButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(425, 6);
            button4.Name = "button4";
            button4.Size = new Size(70, 29);
            button4.TabIndex = 2;
            button4.Text = "Адмін";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += AdminButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(595, 6);
            button3.Name = "button3";
            button3.Size = new Size(70, 29);
            button3.TabIndex = 1;
            button3.Text = "Профіль";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(680, 6);
            button2.Name = "button2";
            button2.Size = new Size(70, 29);
            button2.TabIndex = 0;
            button2.Text = "Вийти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(748, 665);
            Controls.Add(groupBox7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Main";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label1;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Button button1;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}