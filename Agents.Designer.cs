namespace BankManagementSystem
{
    partial class Agents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            AgentDGV = new DataGridView();
            CancleBtn = new Button();
            EditBtn = new Button();
            SubmitBtn = new Button();
            APhoneTb = new TextBox();
            AAddressTb = new TextBox();
            APasswordTb = new TextBox();
            ANameTb = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            settingLb = new Label();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // AgentDGV
            // 
            AgentDGV.BackgroundColor = Color.FromArgb(192, 255, 255);
            AgentDGV.BorderStyle = BorderStyle.Fixed3D;
            AgentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgentDGV.GridColor = Color.ForestGreen;
            AgentDGV.Location = new Point(112, 385);
            AgentDGV.Name = "AgentDGV";
            AgentDGV.RowHeadersWidth = 51;
            AgentDGV.Size = new Size(1109, 242);
            AgentDGV.TabIndex = 48;
            AgentDGV.CellClick += AgentDGV_CellClick;
            AgentDGV.CellContentClick += AgentDGV_CellContentClick;
            // 
            // CancleBtn
            // 
            CancleBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            CancleBtn.Location = new Point(767, 326);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(127, 43);
            CancleBtn.TabIndex = 47;
            CancleBtn.Text = "Delete Infor";
            CancleBtn.UseVisualStyleBackColor = true;
            CancleBtn.Click += CancleBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            EditBtn.Location = new Point(608, 326);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(96, 43);
            EditBtn.TabIndex = 46;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            SubmitBtn.Location = new Point(440, 326);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(90, 43);
            SubmitBtn.TabIndex = 45;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // APhoneTb
            // 
            APhoneTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            APhoneTb.Location = new Point(440, 183);
            APhoneTb.Name = "APhoneTb";
            APhoneTb.Size = new Size(151, 30);
            APhoneTb.TabIndex = 43;
            // 
            // AAddressTb
            // 
            AAddressTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            AAddressTb.Location = new Point(700, 113);
            AAddressTb.Multiline = true;
            AAddressTb.Name = "AAddressTb";
            AAddressTb.Size = new Size(194, 141);
            AAddressTb.TabIndex = 42;
            // 
            // APasswordTb
            // 
            APasswordTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            APasswordTb.Location = new Point(440, 257);
            APasswordTb.Name = "APasswordTb";
            APasswordTb.Size = new Size(159, 30);
            APasswordTb.TabIndex = 41;
            // 
            // ANameTb
            // 
            ANameTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            ANameTb.Location = new Point(440, 114);
            ANameTb.Name = "ANameTb";
            ANameTb.Size = new Size(151, 30);
            ANameTb.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(440, 157);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 35;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(440, 231);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 34;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(702, 87);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 33;
            label4.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(440, 88);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 31;
            label1.Text = "Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1182, 12);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(572, 18);
            label3.Name = "label3";
            label3.Size = new Size(208, 35);
            label3.TabIndex = 29;
            label3.Text = "Manage Agents";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 699);
            panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(123, 12);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // settingLb
            // 
            settingLb.AutoSize = true;
            settingLb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            settingLb.Location = new Point(196, 30);
            settingLb.Name = "settingLb";
            settingLb.Size = new Size(78, 23);
            settingLb.TabIndex = 50;
            settingLb.Text = "Settings";
            settingLb.Click += settingLb_Click;
            // 
            // Agents
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1234, 633);
            Controls.Add(settingLb);
            Controls.Add(pictureBox3);
            Controls.Add(AgentDGV);
            Controls.Add(CancleBtn);
            Controls.Add(EditBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(APhoneTb);
            Controls.Add(AAddressTb);
            Controls.Add(APasswordTb);
            Controls.Add(ANameTb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Agents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agents";
            Load += Agents_Load;
            ((System.ComponentModel.ISupportInitialize)AgentDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AgentDGV;
        private Button CancleBtn;
        private Button EditBtn;
        private Button SubmitBtn;
        private TextBox APhoneTb;
        private TextBox AAddressTb;
        private TextBox APasswordTb;
        private TextBox ANameTb;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label settingLb;
    }
}