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


namespace AIT_MS.Issue
{
    public partial class FormIssue : Form
    {
        public FormIssue()
        {
            InitializeComponent();
        }
        clsIssue objclsIssue = new clsIssue();
        private void FormIssue_Load(object sender, EventArgs e)
        {
            cboxH.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxMH.DropDownStyle = ComboBoxStyle.DropDownList;
            bindmasterheadnames();
            cboxH.Enabled = false;
            cboxItem.Enabled = false;
            lblEnterItemName.Visible = false;
            lblSelectMH.Visible = false;

        }
        private void bindheadnames()
        {
            DataTable dt = new DataTable();
            clsRegister objRegister = new clsRegister();
            dt = objRegister.loadheadnames(cboxMH.SelectedValue.ToString());
            DataRow row = dt.NewRow();
            row["h_name"] = "Please select";
            dt.Rows.InsertAt(row, 0);
            cboxH.DisplayMember = "h_name";
            cboxH.ValueMember = "h_id";
            cboxH.DataSource = dt;


        }

        private void bindItems()
        {
            DataTable dt = new DataTable();
            clsPurchases objPurchases = new clsPurchases();
            dt = objPurchases.loadItems(cboxH.SelectedValue.ToString());
            cboxItem.DisplayMember = "i_name";
            cboxItem.ValueMember = "i_id";
            cboxItem.DataSource = dt;
        }
        private void bindmasterheadnames()
        {

            DataTable dt1 = new DataTable();
            clsRegister objRegister = new clsRegister();

            dt1 = objRegister.loadmhheadnames();
            DataRow row = dt1.NewRow();
            row["mh_name"] = "Please select";
            dt1.Rows.InsertAt(row, 0);
            cboxMH.DisplayMember = "mh_name";
            cboxMH.ValueMember = "mh_id";
            cboxMH.DataSource = dt1;

        }

        private void cboxMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMH.SelectedIndex.ToString() == "0")
            {
                cboxH.Enabled = false;

            }
            else
            {
                lblSelectMH.Visible = false;
                cboxH.Enabled = true;
                bindheadnames();

            }
        }

        private void cboxH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxH.SelectedIndex.ToString() == "0")
            {
                cboxItem.Enabled = false;

            }
            else
            {
                lblEnterItemName.Visible = false;
                cboxItem.Enabled = true;
                bindItems();

            }
        }
    }
}
