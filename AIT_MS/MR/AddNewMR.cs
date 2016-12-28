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

namespace AIT_MS.MR
{
    public partial class AddNewMR : Form
    {
        clsMR objclsMR = new clsMR();
        int flag = 0;
        public AddNewMR()
        {
            InitializeComponent();
        }
        string mainid= "0";
        public AddNewMR(string id)
        {
            InitializeComponent();
            mainid = id;
            updatemr();
            flag = 1;
        }
        public void updatemr()
        {
            DataTable dt2 = new DataTable();
            dt2 = objclsMR.getallmrid(mainid);
            txtMRno.Text = dt2.Rows[0]["mr_no"].ToString();
            
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            clsCreateNewMR objclsCreateNewMR = new clsCreateNewMR();
            if (flag == 0)

            { 
                
                objclsCreateNewMR.createNewMRno(txtMRno.Text);
                this.Hide();
            }
            else { //updatefucntaion here
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddNewMR_Load(object sender, EventArgs e)
        {

        }
    }
}
