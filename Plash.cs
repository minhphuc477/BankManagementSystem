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
    public partial class Plash : Form
    {
        public Plash()
        {
            InitializeComponent();
        }
        private int startP = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            Myprogress.Value = startP;

            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                Login obj = new Login();
                obj.Show();
                this.Hide();

                // Stop the timer
                timer1.Stop();
            }
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }

        private void Plash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
