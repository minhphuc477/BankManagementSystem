using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using Microsoft.Data.SqlClient;

namespace BankManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select the role");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter both Name and Password");
                }
                else
                {
                    Con.Open();
                    string query = "SELECT * FROM AdminTbl WHERE AdName = @AdN AND AdPass = @AdP";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    sda.SelectCommand.Parameters.AddWithValue("@AdN", UnameTb.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@AdP", PasswordTb.Text);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Con.Close();

                    if (dt.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                        {
                            Agents Obj = new Agents();
                            Obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You do not have admin privileges");
                            UnameTb.Text = "";
                            PasswordTb.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Name or Password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                }
            }
            else
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter both Name and Password");
                }
                else
                {
                    Con.Open();
                    string query = "SELECT * FROM AgentTbl WHERE AName = @AgN AND Apass = @AgP";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    sda.SelectCommand.Parameters.AddWithValue("@AgN", UnameTb.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@AgP", PasswordTb.Text);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Con.Close();

                    if (dt.Rows.Count > 0)
                    {
                        MainMenu Obj = new MainMenu();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Agent Name or Password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
            RoleCb.SelectedIndex = -1;
            RoleCb.Text = "Role";
        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
