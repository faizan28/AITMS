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
            AcceptButton = btnLogin;
            txtUseranme.Focus();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        { 
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                clsLogin objLogin = new clsLogin();
                if (chckboxAdminLogin.Checked == true)
                {
                    int adminId = objLogin.AdminLogin(txtUseranme.Text, txtPassword.Text);
                    if (adminId > 0)
                    {
                        // this.Close();
                        Properties.Settings.Default["UserID"] = Convert.ToString(adminId);
                        Properties.Settings.Default["Role"] = 1;
                        Properties.Settings.Default.Save();
                        //MessageBox.Show("Successfully Admin Logined");
                        //for checking pupose
                        //ChangePwd objChangePwd = new ChangePwd();
                        //objChangePwd.Show();
                        Form1 objForm1 = new Form1();
                        objForm1.Show();
                        this.Hide();
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
                    DataTable dt = new DataTable();
                    dt = objLogin.UserInfo(userId);
                    string username = dt.Rows[0]["u_name"].ToString();
                    if (userId > 0)
                    {
                        // this.Close();
                        Properties.Settings.Default["UserName"] = Convert.ToString(username);
                        Properties.Settings.Default["UserID"] = Convert.ToString(userId);
                        Properties.Settings.Default["Role"] = 0;
                        Properties.Settings.Default.Save();
                       // MessageBox.Show("Successfully Login");
                        //ChangePwd objChangePwd = new ChangePwd();
                        //objChangePwd.Show();
                        Form1 objForm1 = new Form1();
                        objForm1.Show();
                        this.Hide();

                    }
                    else
                    {

                        btnRed.Visible = true;
                        lblLoginFailed.Visible = true;

                    }
                }
            }
            catch (Exception ex)
            {
                lblLoginFailed.Visible = true;
                btnRed.Visible = true;
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
