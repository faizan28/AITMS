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
            masterHeadBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bindmasterheadnames();
          
        }
        private void bindmasterheadnames()
        {
            DataTable dt = new DataTable();
            dt = objRegister.loadheadnames();
            masterHeadBox.DisplayMember = "mh_name";
            masterHeadBox.ValueMember = "mh_id";
            masterHeadBox.DataSource = dt;
            
            
           
        }

        private void createButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
