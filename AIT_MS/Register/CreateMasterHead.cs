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

namespace AIT_MS
{
    public partial class addmasterhead : Form
    {
        public addmasterhead()
        {
            InitializeComponent();
        }

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
            }
            catch ( Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }
        }
    }
}
