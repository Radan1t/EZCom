namespace EZCom.Forms.Chat
{
    partial class ChatFormDep
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
            button1 = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(377, 516);
            button1.Name = "button1";
            button1.Size = new Size(61, 56);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-1, 516);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 56);
            textBox1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(-1, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(439, 456);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 55);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(353, 14);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ChatFormDep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 84, 91);
            ClientSize = new Size(439, 572);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "ChatFormDep";
            Text = "ChatFormDep";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
    }
}