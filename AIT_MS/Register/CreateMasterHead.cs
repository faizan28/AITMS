using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using AIT_MS.App_Code;

namespace AIT_MS
{
    public partial class addmasterhead : Form
    {
        public addmasterhead()
        {
            InitializeComponent();
        }
        clsRegister objRegister = new clsRegister();
        private void addmasterhead_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (masterHeadBox.Text == "")
                {
                    MessageBox.Show("Some Fields are empty");
                }
                else
                {
                   bool result = objRegister.createMasterHead(masterHeadBox.Text);
                   if (result == true)
                   {
                       this.Close();
                       //here last form will open
                       MessageBox.Show("Succesfull Inserted");
                   }                 
                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
