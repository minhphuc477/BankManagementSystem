namespace BankManagementSystem
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            GenCb = new ComboBox();
            EducationCb = new ComboBox();
            AcNameTb = new TextBox();
            OccupationTb = new TextBox();
            AcAddressTb = new TextBox();
            AcPhoneTb = new TextBox();
            IncomeTb = new TextBox();
            SubmitBtn = new Button();
            EditBtn = new Button();
            CancleBtn = new Button();
            AccountDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-10, -2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 695);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(621, 38);
            label3.Name = "label3";
            label3.Size = new Size(223, 23);
            label3.TabIndex = 8;
            label3.Text = "NEW ACCOUNT FORM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1362, 10);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(290, 117);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(290, 217);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 11;
            label2.Text = "Education";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(752, 116);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 12;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(1035, 117);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 13;
            label5.Text = "Occupation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(524, 117);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 14;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(524, 217);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 15;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(1035, 217);
            label8.Name = "label8";
            label8.Size = new Size(71, 23);
            label8.TabIndex = 16;
            label8.Text = "Income";
            // 
            // GenCb
            // 
            GenCb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Female", "Male", "Other else" });
            GenCb.Location = new Point(524, 243);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(151, 31);
            GenCb.TabIndex = 17;
            // 
            // EducationCb
            // 
            EducationCb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            EducationCb.FormattingEnabled = true;
            EducationCb.Items.AddRange(new object[] { "Uneducated", "UderGraduate", "Graduated", "Diploma", "Master", "PhD" });
            EducationCb.Location = new Point(290, 243);
            EducationCb.Name = "EducationCb";
            EducationCb.Size = new Size(151, 31);
            EducationCb.TabIndex = 18;
            // 
            // AcNameTb
            // 
            AcNameTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            AcNameTb.Location = new Point(290, 143);
            AcNameTb.Name = "AcNameTb";
            AcNameTb.Size = new Size(151, 30);
            AcNameTb.TabIndex = 19;
            AcNameTb.TextChanged += AcNameTb_TextChanged;
            // 
            // OccupationTb
            // 
            OccupationTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            OccupationTb.Location = new Point(1035, 143);
            OccupationTb.Name = "OccupationTb";
            OccupationTb.Size = new Size(159, 30);
            OccupationTb.TabIndex = 20;
            // 
            // AcAddressTb
            // 
            AcAddressTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            AcAddressTb.Location = new Point(750, 142);
            AcAddressTb.Multiline = true;
            AcAddressTb.Name = "AcAddressTb";
            AcAddressTb.Size = new Size(194, 131);
            AcAddressTb.TabIndex = 21;
            AcAddressTb.TextChanged += AcAddressTb_TextChanged;
            // 
            // AcPhoneTb
            // 
            AcPhoneTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            AcPhoneTb.Location = new Point(524, 143);
            AcPhoneTb.Name = "AcPhoneTb";
            AcPhoneTb.Size = new Size(151, 30);
            AcPhoneTb.TabIndex = 22;
            AcPhoneTb.TextChanged += AcPhoneTb_TextChanged;
            // 
            // IncomeTb
            // 
            IncomeTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            IncomeTb.Location = new Point(1035, 243);
            IncomeTb.Name = "IncomeTb";
            IncomeTb.Size = new Size(159, 30);
            IncomeTb.TabIndex = 23;
            IncomeTb.TextChanged += IncomeTb_TextChanged;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            SubmitBtn.Location = new Point(490, 307);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(90, 43);
            SubmitBtn.TabIndex = 24;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            EditBtn.Location = new Point(658, 307);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(96, 43);
            EditBtn.TabIndex = 25;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // CancleBtn
            // 
            CancleBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            CancleBtn.Location = new Point(817, 307);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(127, 43);
            CancleBtn.TabIndex = 26;
            CancleBtn.Text = "Delete Infor";
            CancleBtn.UseVisualStyleBackColor = true;
            CancleBtn.Click += CancleBtn_Click;
            // 
            // AccountDGV
            // 
            AccountDGV.BackgroundColor = Color.FromArgb(192, 255, 255);
            AccountDGV.BorderStyle = BorderStyle.Fixed3D;
            AccountDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountDGV.GridColor = Color.ForestGreen;
            AccountDGV.Location = new Point(103, 380);
            AccountDGV.Name = "AccountDGV";
            AccountDGV.RowHeadersWidth = 51;
            AccountDGV.Size = new Size(1299, 242);
            AccountDGV.TabIndex = 27;
            AccountDGV.CellClick += AccountDGV_CellClick;
            AccountDGV.CellContentClick += AccountDGV_CellContentClick;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1414, 634);
            Controls.Add(AccountDGV);
            Controls.Add(CancleBtn);
            Controls.Add(EditBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(IncomeTb);
            Controls.Add(AcPhoneTb);
            Controls.Add(AcAddressTb);
            Controls.Add(OccupationTb);
            Controls.Add(AcNameTb);
            Controls.Add(EducationCb);
            Controls.Add(GenCb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAccount";
            Load += AddAccount_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox GenCb;
        private ComboBox EducationCb;
        private TextBox AcNameTb;
        private TextBox OccupationTb;
        private TextBox AcAddressTb;
        private TextBox AcPhoneTb;
        private TextBox IncomeTb;
        private Button SubmitBtn;
        private Button EditBtn;
        private Button CancleBtn;
        private DataGridView AccountDGV;
    }
}