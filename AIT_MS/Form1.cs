using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_MS
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            register objRegister = new register();
            objRegister.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MR.MR objAddNewMR = new MR.MR();
            objAddNewMR.Show();
            this.Hide();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            objLogin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Settings.useraccounts objUserAccounts = new Settings.useraccounts();
            objUserAccounts.Show();
            this.Hide();
        }

      

    }
}
