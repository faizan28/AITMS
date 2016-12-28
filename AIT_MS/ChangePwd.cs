using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace AIT_MS
{
    public partial class ChangePwd: Form
    {
        clsLogin objLogin = new clsLogin();
        public ChangePwd()
        {
            InitializeComponent();
            

        }

        private void chngPw_Load(object sender, EventArgs e)
        {
            label5.Hide();
            txtNewPwd.Enabled = false;
            txtConfirmPwd.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                if (txtNewPwd.Text != "")
                {
                    if (txtNewPwd.Text == txtConfirmPwd.Text)
                    {

                        objLogin.UpdatePwd(Properties.Settings.Default["UserID"].ToString(), txtConfirmPwd.Text);
                        this.Hide();
                            
                        
                    }
                    else
                    {
                        MessageBox.Show("Enter New Password Correctly");
                    }
                }
                else
                {
                    MessageBox.Show("Enter New Password");
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    int count = 0;
                    
                    if ( objLogin.CheckUserPwd(Properties.Settings.Default["UserID"].ToString(), txtOldPwd.Text)>0)
                    {
                        label5.Hide();
                        txtNewPwd.Enabled = true;
                        txtConfirmPwd.Enabled = true;
                        
                        count = 1;
                    }

                    if (count == 0)
                    {
                        label5.Show();
                        
                        txtNewPwd.Enabled = false;
                        txtConfirmPwd.Enabled = false;
                        if (txtOldPwd.Text == "")
                        {
                            label5.Hide();
                        }
                       

                    }
                }
            
            
        }
       
    }
