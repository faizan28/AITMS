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
            cmbPo_no.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPo_no.DropDownStyle = ComboBoxStyle.DropDownList;
            bindmasterheadnames();
            CboxH.Enabled = false;
            CboxItem.Enabled = false;
            lblEnterItemName.Visible = false;
            lblSelectMH.Visible = false;
            txtUsername.Text = Properties.Settings.Default["UserName"].ToString();
            txtUsername.Enabled = false;
            BindComboboxPO();
            
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
        public int serial_no=0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = pGridView.Rows.Add();
                pGridView.Rows[n].Cells[0].Value = serial_no.ToString();
                pGridView.Rows[n].Cells[1].Value = CboxItem.SelectedValue.ToString() ;
                pGridView.Rows[n].Cells[2].Value = cboxMh.Text;
                pGridView.Rows[n].Cells[3].Value = CboxH.Text;
                pGridView.Rows[n].Cells[4].Value = CboxItem.Text;
                pGridView.Rows[n].Cells[5].Value = cmbPo_no.Text /*Should be Change into cmbPo_no.SelectedValue.ToString()*/;
                pGridView.Rows[n].Cells[6].Value = txtQuantity.Text;
                pGridView.Rows[n].Cells[7].Value = txtTprice.Text;
                pGridView.Rows[n].Cells[8].Value = rtxtremarks.Text;
                serial_no++;
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                clsAddNewPurchase objclsAddNewPurchase = new clsAddNewPurchase();
                for (int i = 0; i < serial_no; i++)
                {
                    objclsAddNewPurchase.addnewentry((int.Parse(pGridView.Rows[i].Cells[1].Value.ToString())), pGridView.Rows[i].Cells[4].Value.ToString(), pGridView.Rows[i].Cells[5].Value.ToString(), dateTimePickerPurchaseDate.Text.ToString(), dateTimePickerToday.Text.ToString(), txtSupplier.Text, (int.Parse(pGridView.Rows[i].Cells[6].Value.ToString())), (Convert.ToDouble(pGridView.Rows[i].Cells[7].Value.ToString())), pGridView.Rows[i].Cells[8].Value.ToString(), (int.Parse(txtUsername.Text)/*Should be Change to App.Config UserID*/));
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void cmbPo_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Purchase_Order_no.AddNewPurchaseOrderNo objAddNewPurchaseOrderNo = new Purchase_Order_no.AddNewPurchaseOrderNo();
            objAddNewPurchaseOrderNo.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = pGridView.CurrentCell.RowIndex;
                
                pGridView.Rows.RemoveAt(selectedIndex);
                serial_no--;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }
        public void BindComboboxPO()
        {
            clsAddNewPurchase objclsAddNewPurchase = new clsAddNewPurchase();
            DataTable dt = new DataTable();
            dt = objclsAddNewPurchase.GetAllPO();
            DataRow row = dt.NewRow();
            row["po_no"] = "Please select";
            dt.Rows.InsertAt(row, 0);
            cmbPo_no.DisplayMember = "po_no";
            cmbPo_no.ValueMember = "po_id";
            cmbPo_no.DataSource = dt;
        }
        

        
    }
}
