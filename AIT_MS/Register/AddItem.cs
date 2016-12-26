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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }
        clsRegister objRegister = new clsRegister();
   
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (objRegister.createItem((int.Parse(comboBoxMH_ID.SelectedValue.ToString())), (int.Parse(comboBoxH_ID.SelectedValue.ToString())),(richtxtBoxItemDesc.Text.ToString()),txtboxItemStock.Text,txtboxItemName.Text) == true)
            {
              
                MessageBox.Show("Succesfull Inserted");
                 //here last form will open
                this.Close();
                
            }
        }
        private void bindheadnames()
        {
            DataTable dt = new DataTable();
           
             dt = objRegister.loadheadnames();
            comboBoxH_ID.DisplayMember = "h_name";
            comboBoxH_ID.ValueMember = "h_id";
            comboBoxH_ID.DataSource = dt;
          
           
        }
        private void bindmasterheadnames()
        {
            
            DataTable dt1 = new DataTable();
          
            dt1 = objRegister.loadmhheadnames();
            comboBoxMH_ID.DisplayMember = "mh_name";
            comboBoxMH_ID.ValueMember = "mh_id";
            comboBoxMH_ID.DataSource = dt1;
          
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            comboBoxH_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMH_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            bindheadnames();
            bindmasterheadnames();
          
        }
    }
}
