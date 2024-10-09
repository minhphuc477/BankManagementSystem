using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu Obj = new MainMenu();
            Obj.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            NewPass.Text = string.Empty;
            ThemeCb.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ThemeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select a theme!");

            }
            else if (ThemeCb.SelectedIndex == 0)
            {
                panel4.BackColor = Color.Gold;

            }
            else if (ThemeCb.SelectedIndex == 1)
            {
                panel4.BackColor = Color.Crimson;
            }
            else if (ThemeCb.SelectedIndex == 2)
            {
                panel4.BackColor = Color.Green;
            }
            else if (ThemeCb.SelectedIndex == 3)
            {
                panel4.BackColor = Color.Blue;
            }
            else if (ThemeCb.SelectedIndex == 4)
            {
                panel4.BackColor = Color.PaleTurquoise;
            }
        }

        private void ThemeCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewPass.Text == "")
            {
                MessageBox.Show("Missing Information, Enter new Password");
            }
            try
            {
                // Create a connection string
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30";

                // Update the password in the database
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Create a parameterized SQL query
                    string query = "UPDATE AdminTbl SET AdPass=@AP WHERE AdiD = @AcKey";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AP", NewPass.Text);
                        cmd.Parameters.AddWithValue("@AcKey", 1);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password Updated!");
                        }
                        else
                        {
                            MessageBox.Show("No row selected.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
