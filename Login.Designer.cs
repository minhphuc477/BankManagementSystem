namespace BankManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            UnameTb = new TextBox();
            PasswordTb = new TextBox();
            button1 = new Button();
            label3 = new Label();
            RoleCb = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(541, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F);
            label1.Location = new Point(150, 343);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(152, 409);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Times New Roman", 13.8F);
            UnameTb.Location = new Point(178, 372);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(218, 34);
            UnameTb.TabIndex = 4;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Times New Roman", 13.8F);
            PasswordTb.Location = new Point(178, 438);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(218, 34);
            PasswordTb.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F);
            button1.Location = new Point(235, 488);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 32);
            label3.Name = "label3";
            label3.Size = new Size(360, 25);
            label3.TabIndex = 7;
            label3.Text = "BANK MANAGEMENT SYSTEM";
            // 
            // RoleCb
            // 
            RoleCb.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleCb.FormattingEnabled = true;
            RoleCb.Items.AddRange(new object[] { "Admin", "Agent" });
            RoleCb.Location = new Point(178, 307);
            RoleCb.Name = "RoleCb";
            RoleCb.Size = new Size(218, 33);
            RoleCb.TabIndex = 8;
            RoleCb.SelectedIndexChanged += RoleCb_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(150, 278);
            label4.Name = "label4";
            label4.Size = new Size(61, 26);
            label4.TabIndex = 9;
            label4.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(250, 534);
            label5.Name = "label5";
            label5.Size = new Size(62, 26);
            label5.TabIndex = 10;
            label5.Text = "Reset";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(594, 569);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(RoleCb);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(PasswordTb);
            Controls.Add(UnameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox UnameTb;
        private TextBox PasswordTb;
        private Button button1;
        private Label label3;
        private ComboBox RoleCb;
        private Label label4;
        private Label label5;
    }
}