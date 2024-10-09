using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        SqlConnection Con = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckBalTb.Text = string.Empty;
            FromTb.Text = string.Empty;
            ToTb.Text = string.Empty;
            WdAccountTb.Text = string.Empty;
            WdAmountTb.Text = string.Empty;
            DepAccountTb.Text = string.Empty;
            DepAmTb.Text = string.Empty;
            TranAmountTb.Text = string.Empty;

        }
        private void textBox7_TextChanged(object sender, EventArgs e) { }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CheckBalTb.Text))
            {
                MessageBox.Show("Enter Account Number");
            }
            else
            {
                CheckBalance();
            }
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DepAccountTb.Text) || string.IsNullOrWhiteSpace(DepAmTb.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int newBal = GetNewBalance() + Convert.ToInt32(DepAmTb.Text);
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AcBal = @AB WHERE ACNum = @AcKey", con);
                        cmd.Parameters.AddWithValue("@AB", newBal);
                        cmd.Parameters.AddWithValue("@AcKey", DepAccountTb.Text);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Money Deposit!");

                    Deposit();

                    DepAmTb.Text = "";
                    DepAccountTb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CheckBalance()
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                string query = "SELECT * FROM AccountTbl WHERE ACNum = @AN";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AN", CheckBalTb.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        BalanceLb.Text = "$" + dr["AcBal"].ToString();
                    }
                }
                else
                {
                    BalanceLb.Text = "Account Not Found";
                }
            }
        }

        private int GetNewBalance()
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                string query = "SELECT * FROM AccountTbl WHERE ACNum = @AN";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AN", CheckBalTb.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                int balance = 0;
                if (dt.Rows.Count > 0)
                {
                    balance = Convert.ToInt32(dt.Rows[0]["AcBal"]);
                }
                else
                {
                    BalanceLb.Text = "Account Not Found";
                }

                return balance;
            }
        }

        private void Deposit()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TransactionTbl(TName, TDate, TAmt, TACNum) VALUES (@TN, @TD, @TA, @TAC)", con);
                    cmd.Parameters.AddWithValue("@TN", "Deposit");
                    cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@TA", DepAmTb.Text);
                    cmd.Parameters.AddWithValue("@TAC", DepAccountTb.Text); // Fix parameter name here

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Withdraw()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TransactionTbl(TName, TDate, TAmt, TACNum) VALUES (@TN, @TD, @TA, @TAC)", con);
                    cmd.Parameters.AddWithValue("@TN", "Withdraw");
                    cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@TA", WdAmountTb.Text);
                    cmd.Parameters.AddWithValue("@TAC", WdAccountTb.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WdBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WdAccountTb.Text) || string.IsNullOrWhiteSpace(WdAmountTb.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Withdraw();
                int newBal = GetNewBalance() - Convert.ToInt32(WdAmountTb.Text);
                if (newBal < 0)
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AcBal = @AB WHERE ACNum = @AcKey", con);
                            cmd.Parameters.AddWithValue("@AB", newBal);
                            cmd.Parameters.AddWithValue("@AcKey", WdAccountTb.Text);

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Money Withdrawn!");

                        WdAmountTb.Text = "";
                        WdAccountTb.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (FromTb.Text == "")
                {
                    MessageBox.Show("Enter Source Account");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT * FROM AccountTbl WHERE ACNum = @ACNum";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ACNum", FromTb.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            CheckAvailBalance();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist");
                            FromTb.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void CheckAvailBalance()
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT AcBal FROM AccountTbl WHERE ACNum = @ACNum";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ACNum", FromTb.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        BalanceLb1.Text = "$" + result.ToString();
                    }
                    else
                    {
                        BalanceLb1.Text = "Account Not Found";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (ToTb.Text == "")
                {
                    MessageBox.Show("Enter Destination Account");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT * FROM AccountTbl WHERE ACNum = @ACNum";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ACNum", ToTb.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            CheckAvailBalance();
                            con.Close();

                            if (ToTb.Text == FromTb.Text)
                            {
                                MessageBox.Show("Source and Destination are the same");
                                ToTb.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Account exist, qualify for transaction!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist");
                            ToTb.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        private int GetBalance(string accountNumber)
        {
            int balance = 0;

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT AcBal FROM AccountTbl WHERE ACNum = @AcKey";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@AcKey", accountNumber);

                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int bal))
                    {
                        balance = bal;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return balance;
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int transferAmount = Convert.ToInt32(TranAmountTb.Text);
                int currentBalance = GetBalance(FromTb.Text);

                if (transferAmount > currentBalance)
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    SubtractBal();
                    AddBal();
                    Transfer();
                }
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(ToTb.Text) || string.IsNullOrEmpty(FromTb.Text) || string.IsNullOrEmpty(TranAmountTb.Text))
            {
                MessageBox.Show("Missing information, please fill all the fields!");
                return false;
            }

            if (!int.TryParse(TranAmountTb.Text, out int tranAmount))
            {
                MessageBox.Show("Invalid amount");
                return false;
            }

            return true;
        }

        private void SubtractBal()
        {
            int currentBalance = GetBalance(FromTb.Text);
            int newBalance = currentBalance - Convert.ToInt32(TranAmountTb.Text);

            UpdateBalance(FromTb.Text, newBalance);
        }

        private void AddBal()
        {
            int currentBalance = GetBalance(ToTb.Text);
            int newBalance = currentBalance + Convert.ToInt32(TranAmountTb.Text);

            UpdateBalance(ToTb.Text, newBalance);
        }

        private void UpdateBalance(string accountNumber, int newBalance)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE AccountTbl SET AcBal = @AB WHERE ACNum = @AcKey";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AB", newBalance);
                        cmd.Parameters.AddWithValue("@AcKey", accountNumber);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Transfer()
        {
            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO TranferTbl(TrSrc, TrDest, TrAmt, TrDate) VALUES (@TS, @TD, @TA, @TDa)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TS", FromTb.Text);
                        cmd.Parameters.AddWithValue("@TD", ToTb.Text);
                        cmd.Parameters.AddWithValue("@TA", TranAmountTb.Text);
                        cmd.Parameters.AddWithValue("@TDa", DateTime.Now.Date);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Money Transfer!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckBalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void WdAccountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TranAmountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepAccountTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

