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
    public partial class addhead : Form
    {
        public addhead()
        {
            InitializeComponent();
        }
        clsRegister objRegister = new clsRegister();
        private void addhead_Load(object sender, EventArgs e)
        {
            lblEnterHead.Visible = false;
            masterHeadBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bindmasterheadnames();
          
        }
        private void bindmasterheadnames()
        {
            DataTable dt = new DataTable();
            dt = objRegister.loadmhheadnames();
            masterHeadBox.DisplayMember = "mh_name";
            masterHeadBox.ValueMember = "mh_id";
            masterHeadBox.DataSource = dt;
            
            
           
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (headBox.Text != "")
            {
                if (objRegister.createHead(headBox.Text, int.Parse(masterHeadBox.SelectedValue.ToString())) == true)
                {
                   
                    this.Close();
                    //here last form will open

                }
            }
            else
            {
                lblEnterHead.Visible = true;
            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void headBox_TextChanged(object sender, EventArgs e)
        {
            lblEnterHead.Visible = false;
        }
    }
}
