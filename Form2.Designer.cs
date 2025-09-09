namespace login
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLoadTweets = new Button();
            lstTweets = new ListBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.twitter_x_new_logo_square_x_icon_256075;
            pictureBox1.Location = new Point(-6, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(260, 169);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(38, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "label1";
            lblUsername.Click += lblUsername_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(109, 23);
            txtUsername.TabIndex = 2;
            // 
            // btnLoadTweets
            // 
            btnLoadTweets.BackColor = SystemColors.Desktop;
            btnLoadTweets.BackgroundImageLayout = ImageLayout.None;
            btnLoadTweets.Cursor = Cursors.Hand;
            btnLoadTweets.FlatStyle = FlatStyle.Flat;
            btnLoadTweets.Font = new Font("Corbel", 9F, FontStyle.Italic, GraphicsUnit.Point, 238);
            btnLoadTweets.ForeColor = SystemColors.ButtonFace;
            btnLoadTweets.Location = new Point(12, 69);
            btnLoadTweets.Name = "btnLoadTweets";
            btnLoadTweets.Size = new Size(109, 29);
            btnLoadTweets.TabIndex = 3;
            btnLoadTweets.Text = "Pobierz twitty";
            btnLoadTweets.UseMnemonic = false;
            btnLoadTweets.UseVisualStyleBackColor = false;
            btnLoadTweets.Click += btnLoadTweets_Click;
            // 
            // lstTweets
            // 
            lstTweets.BackColor = SystemColors.ActiveCaptionText;
            lstTweets.BorderStyle = BorderStyle.None;
            lstTweets.Dock = DockStyle.Bottom;
            lstTweets.ForeColor = SystemColors.Menu;
            lstTweets.FormattingEnabled = true;
            lstTweets.ItemHeight = 15;
            lstTweets.Location = new Point(0, 152);
            lstTweets.Name = "lstTweets";
            lstTweets.Size = new Size(494, 420);
            lstTweets.TabIndex = 4;
            lstTweets.SelectedIndexChanged += lstTweets_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(420, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(62, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Powrot";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(494, 572);
            Controls.Add(btnBack);
            Controls.Add(lstTweets);
            Controls.Add(btnLoadTweets);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnLoadTweets;
        private ListBox lstTweets;
        private Button btnBack;
    }

}