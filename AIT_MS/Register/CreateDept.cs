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
namespace AIT_MS
{
    public partial class CreateDept : Form
    {
        public CreateDept()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==null || richTextBox1.Text==null)
            {
                MessageBox.Show("Some Fields are Empty ");

            }
            else
         {

                clsRegister objregister = new clsRegister();
                try
                {
                if (objregister.AddDept(textBox1.Text, richTextBox1.Text) == true)
                {
                    MessageBox.Show("Successfull");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            
                }   
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CreateDept_Load(object sender, EventArgs e)
        {

        }
    }
}
