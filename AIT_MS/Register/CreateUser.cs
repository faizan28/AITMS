using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIT_MS.App_Code;

namespace AIT_MS.Register
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        clsCreateNewUser objCreateNewUser = new clsCreateNewUser();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == txtReEnterPassword.Text)
                {
                    objCreateNewUser.createuser(txtUserName.Text, txtPassword.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password Doesn't Match");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR:" + ex.Message);
            }

        }
    }
}
