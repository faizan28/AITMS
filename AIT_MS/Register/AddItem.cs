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
            if (txtboxItemName.Text != "" && txtboxItemStock.Text != "" && comboBoxH_ID.Enabled==true)
            {
                if (objRegister.createItem((int.Parse(comboBoxMH_ID.SelectedValue.ToString())), (int.Parse(comboBoxH_ID.SelectedValue.ToString())), (richtxtBoxItemDesc.Text.ToString()), txtboxItemStock.Text, txtboxItemName.Text) == true)
                {


                    //here last form will open
                    this.Hide();

                }
            }
            else
            {
               
                if (txtboxItemName.Text == "" && txtboxItemStock.Text == "" & comboBoxH_ID.Enabled==false)
                {
                    lblEnterItemName.Visible = true;
                    lblEnterStock.Visible = true;
                    lblSelectMH.Visible = true;
                }
                if (comboBoxH_ID.Enabled == false)
                {
                    lblSelectMH.Visible = true;
                }
                else if (txtboxItemName.Text == "" && txtboxItemStock.Text == "")
                {
                    lblEnterStock.Visible = true;
                    lblEnterItemName.Visible = true;
                }
                else if(txtboxItemName.Text == "")
                {
                    lblEnterItemName.Visible = true;
                }
                else
                {
                    lblEnterStock.Visible = true;
                }
            }
        }
        private void bindheadnames()
        {
            DataTable dt = new DataTable();

            dt = objRegister.loadheadnames(comboBoxMH_ID.SelectedValue.ToString());
            comboBoxH_ID.DisplayMember = "h_name";
            comboBoxH_ID.ValueMember = "h_id";
            comboBoxH_ID.DataSource = dt;
          
           
        }
        private void bindmasterheadnames()
        {
            
            DataTable dt1 = new DataTable();
          
            dt1 = objRegister.loadmhheadnames();
            DataRow row = dt1.NewRow();
            row["mh_name"] = "Please select";
            dt1.Rows.InsertAt(row, 0);
            comboBoxMH_ID.DisplayMember = "mh_name";
            comboBoxMH_ID.ValueMember = "mh_id";
            comboBoxMH_ID.DataSource = dt1;
          
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            comboBoxH_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMH_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            bindmasterheadnames();
            comboBoxH_ID.Enabled = false;
            lblEnterItemName.Visible = false;
            lblEnterStock.Visible = false;
            lblSelectMH.Visible = false;
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBoxMH_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMH_ID.SelectedIndex.ToString() == "0")
            {
                comboBoxH_ID.Enabled = false;

            }
            else
            {
                lblSelectMH.Visible = false;
                comboBoxH_ID.Enabled = true;
                bindheadnames();

            }
        }

        private void txtboxItemName_TextChanged(object sender, EventArgs e)
        {
            lblEnterItemName.Visible = false;
        }

        private void txtboxItemStock_TextChanged(object sender, EventArgs e)
        {
            lblEnterStock.Visible = false;
        }
    }
}
