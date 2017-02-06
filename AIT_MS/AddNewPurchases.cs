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
    public partial class AddNewPurchases : Form
    {
        public AddNewPurchases()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddNewPurchases_Load(object sender, EventArgs e)
        {
            CboxH.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxMh.DropDownStyle = ComboBoxStyle.DropDownList;
            bindmasterheadnames();
            CboxH.Enabled = false;
            CboxItem.Enabled = false;
            lblEnterItemName.Visible = false;
            lblSelectMH.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void bindheadnames()
        {
            DataTable dt = new DataTable();
            clsRegister objRegister = new clsRegister();
            dt = objRegister.loadheadnames(cboxMh.SelectedValue.ToString());
            DataRow row = dt.NewRow();
            row["h_name"] = "Please select";
            dt.Rows.InsertAt(row, 0);
            CboxH.DisplayMember = "h_name";
            CboxH.ValueMember = "h_id";
            CboxH.DataSource = dt;


        }
       
        private void bindItems()
        {
            DataTable dt = new DataTable();
            clsPurchases objPurchases = new clsPurchases();
            dt = objPurchases.loadItems(CboxH.SelectedValue.ToString());
            CboxItem.DisplayMember = "i_name";
            CboxItem.ValueMember = "i_id";
            CboxItem.DataSource = dt;
        }
        private void bindmasterheadnames()
        {

            DataTable dt1 = new DataTable();
            clsRegister objRegister = new clsRegister();

            dt1 = objRegister.loadmhheadnames();
            DataRow row = dt1.NewRow();
            row["mh_name"] = "Please select";
            dt1.Rows.InsertAt(row, 0);
            cboxMh.DisplayMember = "mh_name";
            cboxMh.ValueMember = "mh_id";
            cboxMh.DataSource = dt1;

        }

        private void cboxMh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMh.SelectedIndex.ToString() == "0")
            {
                CboxH.Enabled = false;

            }
            else
            {
                lblSelectMH.Visible = false;
                CboxH.Enabled = true;
                bindheadnames();

            }
        }

        private void CboxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CboxH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxH.SelectedIndex.ToString() == "0")
            {
                CboxItem.Enabled = false;

            }
            else
            {
                lblEnterItemName.Visible = false;
                CboxItem.Enabled = true;
                bindItems();

            }
        }
        

        
    }
}
