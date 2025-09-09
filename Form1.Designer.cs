namespace login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.WindowText;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._64cebc6c19c2fe31de94c78e_X_vector_logo_download;
            pictureBox1.Location = new Point(174, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowText;
            label2.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lavender;
            label2.Location = new Point(207, 278);
            label2.Name = "label2";
            label2.Size = new Size(65, 29);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profile;
            pictureBox2.Location = new Point(105, 380);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(105, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 1);
            panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.WindowText;
            pictureBox3.Image = Properties.Resources.locked;
            pictureBox3.Location = new Point(105, 443);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(105, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 1);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Kurri Island Caps Italics", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(174, 511);
            button1.Name = "button1";
            button1.Size = new Size(126, 32);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Provicali", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(219, 626);
            label1.Name = "label1";
            label1.Size = new Size(27, 13);
            label1.TabIndex = 6;
            label1.Text = "Exit";
            label1.Click += label1_Click;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.MenuText;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.ForeColor = Color.Ivory;
            txtusername.Location = new Point(135, 388);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(230, 16);
            txtusername.TabIndex = 7;
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.InfoText;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.ForeColor = SystemColors.Window;
            txtpassword.Location = new Point(135, 451);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(230, 16);
            txtpassword.TabIndex = 7;
            txtpassword.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(298, 496);
            label3.Name = "label3";
            label3.Size = new Size(67, 12);
            label3.TabIndex = 8;
            label3.Text = "Clear Fields";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(455, 665);
            Controls.Add(label3);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label3;
    }
}
