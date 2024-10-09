using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;


namespace BankManagementSystem
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
            DisplayAccount();
        }

        SqlConnection Con = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAccount()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM AccountTbl";
                SqlCommand cmd = new SqlCommand(query, Con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                AccountDGV.DataSource = dataTable;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            AcNameTb.Text = "";
            AcPhoneTb.Text = "";
            AcAddressTb.Text = "";
            GenCb.SelectedIndex = -1;
            OccupationTb.Text = "";
            EducationCb.SelectedIndex = -1;
            IncomeTb.Text = "";
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void AcNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void IncomeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcAddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneTb.Text == "" || AcAddressTb.Text == "" || GenCb.SelectedIndex == -1 || OccupationTb.Text == "" || EducationCb.SelectedIndex == -1 || IncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(ACName,ACPhone,ACAddress,ACGen,ACOccup,AcEduc,AcInc,AcBal )values(@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB)", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", GenCb.SelectedItem.ToString()); //look at this again
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString()); //look at this again
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created!");

                    Con.Close();
                    Reset();
                    DisplayAccount();

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
                if (AccountDGV.SelectedRows.Count > 0)
                {
                    int accountId = Convert.ToInt32(AccountDGV.SelectedRows[0].Cells["ACNum"].Value);

                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM AccountTbl WHERE ACNum = @AN", con))
                        {
                            cmd.Parameters.AddWithValue("@AN", accountId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Account Deleted!");
                                DisplayAccount();
                                Reset();
                            }
                            else
                            {
                                MessageBox.Show("Account not found!");
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

        int Key = 0;
        private void AccountDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AccountDGV.Rows[e.RowIndex];
                AcNameTb.Text = row.Cells["ACName"].Value.ToString();
                AcPhoneTb.Text = row.Cells["ACPhone"].Value.ToString();
                AcAddressTb.Text = row.Cells["ACAddress"].Value.ToString();
                GenCb.SelectedItem = row.Cells["ACGen"].Value.ToString();
                OccupationTb.Text = row.Cells["ACOccup"].Value.ToString();
                EducationCb.SelectedItem = row.Cells["AcEduc"].Value.ToString();
                IncomeTb.Text = row.Cells["AcInc"].Value.ToString();

                Key = Convert.ToInt32(row.Cells["ACNum"].Value.ToString());
            }
        }

        private void AccountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == AccountDGV.Columns["DeleteColumn"].Index)
            {
                int accountId = Convert.ToInt32(AccountDGV.Rows[e.RowIndex].Cells["ACNum"].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM AccountTbl WHERE ACNum = @AN", con))
                        {
                            cmd.Parameters.AddWithValue("@AN", accountId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Account Deleted!");
                                Reset();
                                DisplayAccount();
                            }
                            else
                            {
                                MessageBox.Show("Account not found!");
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneTb.Text == "" || AcAddressTb.Text == "" || GenCb.SelectedIndex == -1 || OccupationTb.Text == "" || EducationCb.SelectedIndex == -1 || IncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            try
            {
                if (AccountDGV.SelectedRows.Count > 0)
                {
                    int accountId = Convert.ToInt32(AccountDGV.SelectedRows[0].Cells["ACNum"].Value); // Replace "ID" with the correct column name for the account identifier

                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MPhuc\\Documents\\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET ACName = @AN, ACPhone = @AP, ACAddress = @AA, ACGen = @AG, ACOccup = @AO, ACEduc = @AE, ACInc = @AI WHERE ACNum = @AcKey", con))
                        {
                            cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                            cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                            cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);

                            // Check if the selected item is not null before accessing its properties
                            cmd.Parameters.AddWithValue("@AG", GenCb.SelectedItem != null ? GenCb.SelectedItem.ToString() : string.Empty);
                            cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);

                            // Check if the selected item is not null before accessing its properties
                            cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem != null ? EducationCb.SelectedItem.ToString() : string.Empty);

                            cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                            cmd.Parameters.AddWithValue("@AcKey", accountId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Account Updated!");
                                Reset();
                                DisplayAccount();
                            }
                            else
                            {
                                MessageBox.Show("Account not found!");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
