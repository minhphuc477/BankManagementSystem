namespace BankManagementSystem
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            WdBtn = new Button();
            checkBalance = new Button();
            CheckBalTb = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            BalanceLb = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label11 = new Label();
            WdAmountTb = new TextBox();
            WdAccountTb = new TextBox();
            label10 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            label6 = new Label();
            DepAmTb = new TextBox();
            DepAccountTb = new TextBox();
            DepositBtn = new Button();
            label12 = new Label();
            panel5 = new Panel();
            BalanceLb1 = new Label();
            label5 = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            TranAmountTb = new TextBox();
            label2 = new Label();
            ToTb = new TextBox();
            FromTb = new TextBox();
            TranferBtn = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // WdBtn
            // 
            WdBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            WdBtn.Location = new Point(419, 75);
            WdBtn.Name = "WdBtn";
            WdBtn.Size = new Size(103, 43);
            WdBtn.TabIndex = 45;
            WdBtn.Text = "Withdraw";
            WdBtn.UseVisualStyleBackColor = true;
            WdBtn.Click += WdBtn_Click;
            // 
            // checkBalance
            // 
            checkBalance.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            checkBalance.Location = new Point(358, 42);
            checkBalance.Name = "checkBalance";
            checkBalance.Size = new Size(101, 47);
            checkBalance.TabIndex = 44;
            checkBalance.Text = "Check";
            checkBalance.UseVisualStyleBackColor = true;
            checkBalance.Click += checkBalance_Click;
            // 
            // CheckBalTb
            // 
            CheckBalTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            CheckBalTb.Location = new Point(137, 52);
            CheckBalTb.Name = "CheckBalTb";
            CheckBalTb.Size = new Size(179, 30);
            CheckBalTb.TabIndex = 39;
            CheckBalTb.TextChanged += CheckBalTb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(137, 26);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 30;
            label1.Text = "Check Your Balance";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1362, 12);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(702, 16);
            label3.Name = "label3";
            label3.Size = new Size(175, 35);
            label3.TabIndex = 28;
            label3.Text = "Transactions";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, -1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(96, 695);
            panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(BalanceLb);
            panel2.Controls.Add(CheckBalTb);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBalance);
            panel2.Location = new Point(214, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1113, 116);
            panel2.TabIndex = 47;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.Location = new Point(864, 43);
            button1.Name = "button1";
            button1.Size = new Size(101, 47);
            button1.TabIndex = 46;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BalanceLb
            // 
            BalanceLb.AutoSize = true;
            BalanceLb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            BalanceLb.Location = new Point(661, 54);
            BalanceLb.Name = "BalanceLb";
            BalanceLb.Size = new Size(125, 23);
            BalanceLb.TabIndex = 45;
            BalanceLb.Text = "BalanceLable";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(WdAmountTb);
            panel3.Controls.Add(WdAccountTb);
            panel3.Controls.Add(WdBtn);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(214, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(546, 167);
            panel3.TabIndex = 48;
            panel3.Paint += panel3_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 12);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 46;
            label7.Text = "Withdraw";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(39, 125);
            label11.Name = "label11";
            label11.Size = new Size(76, 23);
            label11.TabIndex = 47;
            label11.Text = "Amount";
            // 
            // WdAmountTb
            // 
            WdAmountTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            WdAmountTb.Location = new Point(219, 119);
            WdAmountTb.Name = "WdAmountTb";
            WdAmountTb.Size = new Size(151, 30);
            WdAmountTb.TabIndex = 46;
            WdAmountTb.TextChanged += textBox7_TextChanged;
            // 
            // WdAccountTb
            // 
            WdAccountTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            WdAccountTb.Location = new Point(219, 61);
            WdAccountTb.Name = "WdAccountTb";
            WdAccountTb.Size = new Size(151, 30);
            WdAccountTb.TabIndex = 44;
            WdAccountTb.TextChanged += WdAccountTb_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(39, 64);
            label10.Name = "label10";
            label10.Size = new Size(151, 23);
            label10.TabIndex = 43;
            label10.Text = "Account Number";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(DepAmTb);
            panel4.Controls.Add(DepAccountTb);
            panel4.Controls.Add(DepositBtn);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(772, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(555, 167);
            panel4.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.Location = new Point(38, 12);
            label14.Name = "label14";
            label14.Size = new Size(76, 25);
            label14.TabIndex = 50;
            label14.Text = "Deposit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(38, 125);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 49;
            label6.Text = "Amount";
            // 
            // DepAmTb
            // 
            DepAmTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            DepAmTb.Location = new Point(211, 118);
            DepAmTb.Name = "DepAmTb";
            DepAmTb.Size = new Size(151, 30);
            DepAmTb.TabIndex = 46;
            // 
            // DepAccountTb
            // 
            DepAccountTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            DepAccountTb.Location = new Point(211, 61);
            DepAccountTb.Name = "DepAccountTb";
            DepAccountTb.Size = new Size(151, 30);
            DepAccountTb.TabIndex = 44;
            DepAccountTb.TextChanged += DepAccountTb_TextChanged;
            // 
            // DepositBtn
            // 
            DepositBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            DepositBtn.Location = new Point(414, 75);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(96, 43);
            DepositBtn.TabIndex = 45;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label12.Location = new Point(38, 64);
            label12.Name = "label12";
            label12.Size = new Size(151, 23);
            label12.TabIndex = 43;
            label12.Text = "Account Number";
            label12.Click += label12_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(BalanceLb1);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(TranAmountTb);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(ToTb);
            panel5.Controls.Add(FromTb);
            panel5.Controls.Add(TranferBtn);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(214, 363);
            panel5.Name = "panel5";
            panel5.Size = new Size(1113, 197);
            panel5.TabIndex = 49;
            // 
            // BalanceLb1
            // 
            BalanceLb1.AutoSize = true;
            BalanceLb1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            BalanceLb1.Location = new Point(432, 65);
            BalanceLb1.Name = "BalanceLb1";
            BalanceLb1.Size = new Size(76, 23);
            BalanceLb1.TabIndex = 55;
            BalanceLb1.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(596, 96);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 54;
            label5.Text = "Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 13);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 53;
            label8.Text = "Stranfer";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(391, 133);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 52;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(391, 62);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // TranAmountTb
            // 
            TranAmountTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            TranAmountTb.Location = new Point(769, 96);
            TranAmountTb.Name = "TranAmountTb";
            TranAmountTb.Size = new Size(151, 30);
            TranAmountTb.TabIndex = 50;
            TranAmountTb.TextChanged += TranAmountTb_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(39, 131);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 47;
            label2.Text = "To";
            // 
            // ToTb
            // 
            ToTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            ToTb.Location = new Point(219, 133);
            ToTb.Name = "ToTb";
            ToTb.Size = new Size(151, 30);
            ToTb.TabIndex = 46;
            // 
            // FromTb
            // 
            FromTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            FromTb.Location = new Point(219, 62);
            FromTb.Name = "FromTb";
            FromTb.Size = new Size(151, 30);
            FromTb.TabIndex = 44;
            FromTb.TextChanged += FromTb_TextChanged;
            // 
            // TranferBtn
            // 
            TranferBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            TranferBtn.Location = new Point(972, 89);
            TranferBtn.Name = "TranferBtn";
            TranferBtn.Size = new Size(96, 43);
            TranferBtn.TabIndex = 45;
            TranferBtn.Text = "Stranfer";
            TranferBtn.UseVisualStyleBackColor = true;
            TranferBtn.Click += TransferBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(39, 62);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 43;
            label4.Text = "From";
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1414, 591);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Transactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button WdBtn;
        private Button checkBalance;
        private TextBox CheckBalTb;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label BalanceLb;
        private Panel panel3;
        private TextBox WdAmountTb;
        private TextBox WdAccountTb;
        private Label label10;
        private Label label11;
        private Panel panel4;
        private TextBox DepAmTb;
        private TextBox DepAccountTb;
        private Button DepositBtn;
        private Label label12;
        private Panel panel5;
        private Label label2;
        private TextBox ToTb;
        private TextBox FromTb;
        private Button TranferBtn;
        private Label label4;
        private Label label7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private TextBox TranAmountTb;
        private Label label6;
        private Label label14;
        private Label label8;
        private Label label5;
        private Button button1;
        private Label BalanceLb1;
    }
}