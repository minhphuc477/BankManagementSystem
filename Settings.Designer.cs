namespace BankManagementSystem
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label3 = new Label();
            NewPass = new TextBox();
            label1 = new Label();
            ThemeCb = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightCyan;
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(-2, -2);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(84, 500);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(252, 21);
            label3.Name = "label3";
            label3.Size = new Size(116, 35);
            label3.TabIndex = 9;
            label3.Text = "Settings";
            // 
            // NewPass
            // 
            NewPass.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            NewPass.Location = new Point(164, 115);
            NewPass.Name = "NewPass";
            NewPass.Size = new Size(192, 30);
            NewPass.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(164, 89);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 23;
            label1.Text = "Admin New Password";
            // 
            // ThemeCb
            // 
            ThemeCb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            ThemeCb.FormattingEnabled = true;
            ThemeCb.Items.AddRange(new object[] { "Gold ", "Crimson", "Green", "Blue", "PaleTurquoise" });
            ThemeCb.Location = new Point(164, 208);
            ThemeCb.Name = "ThemeCb";
            ThemeCb.Size = new Size(192, 31);
            ThemeCb.TabIndex = 28;
            ThemeCb.SelectedIndexChanged += ThemeCb_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(164, 182);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 27;
            label7.Text = "Theme";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.Location = new Point(373, 108);
            button1.Name = "button1";
            button1.Size = new Size(90, 43);
            button1.TabIndex = 29;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button3.Location = new Point(373, 201);
            button3.Name = "button3";
            button3.Size = new Size(90, 43);
            button3.TabIndex = 31;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(505, 12);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 285);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 33;
            label2.Text = "Reset";
            label2.Click += label2_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(557, 319);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(ThemeCb);
            Controls.Add(label7);
            Controls.Add(NewPass);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel4);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label3;
        private TextBox NewPass;
        private Label label1;
        private ComboBox ThemeCb;
        private Label label7;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox2;
        private Label label2;
    }
}