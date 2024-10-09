using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();
        }
        SqlConnection Con = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Agents_Load(object sender, EventArgs e)
        {

        }
        private void DisplayAgents()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM AgentTbl";
                SqlCommand cmd = new SqlCommand(query, Con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                AgentDGV.DataSource = dataTable;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            ANameTb.Text = "";
            APhoneTb.Text = "";
            AAddressTb.Text = "";
            APasswordTb.Text = "";
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || APhoneTb.Text == "" || AAddressTb.Text == "" || APasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTbl(AName,Apass,Aphone,Aaddress)values(@AN,@AP,@APh,@AA)", Con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@APh", APhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AA", APasswordTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Created!");

                    Con.Close();
                    Reset();
                    DisplayAgents();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AgentDGV.SelectedRows.Count > 0)
                {
                    int accountId = Convert.ToInt32(AgentDGV.SelectedRows[0].Cells["Ald"].Value);

                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM AgentTbl WHERE Ald = @AN", con))
                        {
                            cmd.Parameters.AddWithValue("@AN", accountId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Agent Deleted!");
                                DisplayAgents();
                                Reset();
                            }
                            else
                            {
                                MessageBox.Show("Agent not found!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No account selected!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == AgentDGV.Columns["DeleteColumn"].Index)
            {
                int accountId = Convert.ToInt32(AgentDGV.Rows[e.RowIndex].Cells["Ald"].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM AgentTbl WHERE Ald = @AN", con))
                        {
                            cmd.Parameters.AddWithValue("@AN", accountId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Agent Deleted!");
                                Reset();
                                DisplayAgents();
                            }
                            else
                            {
                                MessageBox.Show("Agent not found!");
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
        int Key = 0;
        private void AgentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AgentDGV.Rows[e.RowIndex];
                ANameTb.Text = row.Cells["AName"].Value.ToString();
                APhoneTb.Text = row.Cells["Aphone"].Value.ToString();
                AAddressTb.Text = row.Cells["Aaddress"].Value.ToString();
                APasswordTb.Text = row.Cells["Apass"].Value.ToString();

                Key = Convert.ToInt32(row.Cells["Ald"].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || APhoneTb.Text == "" || AAddressTb.Text == "" || APasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            try
            {
                if (AgentDGV.SelectedRows.Count > 0)
                {
                    int accountId = Convert.ToInt32(AgentDGV.SelectedRows[0].Cells["Ald"].Value); // Replace "ID" with the correct column name for the account identifier

                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE AgentTbl SET AName = @AN, Apass=@AP , Aphone = @APh, Aaddress = @AA WHERE Ald = @AcKey", con))
                        //AName,Apass,Aphone,Aaddress  @AN,@APA,@APh,@AA
                        {
                            cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                            cmd.Parameters.AddWithValue("@APh", APhoneTb.Text);
                            cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                            cmd.Parameters.AddWithValue("@AP", APasswordTb.Text);
                            cmd.Parameters.AddWithValue("@AcKey", accountId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Agent Updated!");
                                Reset();
                                DisplayAgents();
                            }
                            else
                            {
                                MessageBox.Show("Agent not found!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Agent selected!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void settingLb_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            obj.Show();
        }
    }
}
