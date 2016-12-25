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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
     
        private void Login_Load(object sender, EventArgs e)
        {
            btnRed.Enabled = false;
            btnRed.Visible = false;
            lblLoginFailed.Visible = false;
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        { 
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            clsLogin objLogin = new clsLogin();
            if (chckboxAdminLogin.Checked == true)
            {
                int adminId = objLogin.AdminLogin(txtUseranme.Text, txtPassword.Text);
                if (adminId > 0)
                {
                    // this.Close();
                    MessageBox.Show("Successfully Admin Logined");
                }
                else
                {

                    btnRed.Visible = true;
                    lblLoginFailed.Visible = true;
                    //chckboxAdminLogin.Visible = false;

                }

            }
            else
            {
                int userId = objLogin.UserLogin(txtUseranme.Text, txtPassword.Text);
                if (userId > 0)
                {
                    // this.Close();
                    MessageBox.Show("Successfully Logined");
                }
                else
                {

                    btnRed.Visible = true;
                    lblLoginFailed.Visible = true;

                }
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {

        }
    }
}
