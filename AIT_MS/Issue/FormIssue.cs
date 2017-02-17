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
using AIT_MS.Register;


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
            cboxIssueTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCub.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            
            bindmasterheadnames();
            cboxH.Enabled = false;
            cboxItem.Enabled = false;
            lblEnterItemName.Visible = false;
            lblSelectMH.Visible = false;
            
            cboxIssueTo.Items.Insert(0,"Room"); 
            cboxIssueTo.Items.Insert(1,"Staff");

            BindComboBoxDept();
            cboxRoomNo.Enabled = false;
            cboxStaff.Hide();
            cboxRoomNo.Hide();
            cboxCub.Hide();
            cboxDept.Hide();

            lblCub.Hide();
            lblDept.Hide();
            lblRoom.Hide();
            lblSatff.Hide();
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
                cboxItem.Enabled = false;
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
        int serialNo = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                insertIteminGrid();



            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void insertIteminGrid()
        {
            int n = gridIssueItems.Rows.Add();
            gridIssueItems.Rows[n].Cells[0].Value = serialNo.ToString();
            gridIssueItems.Rows[n].Cells[1].Value = cboxItem.SelectedValue.ToString();
            gridIssueItems.Rows[n].Cells[2].Value = cboxMH.Text;
            gridIssueItems.Rows[n].Cells[3].Value = cboxH.Text ;
            gridIssueItems.Rows[n].Cells[4].Value = cboxItem.Text;
            if (cboxStaff.Visible == false)
            {
                gridIssueItems.Rows[n].Cells[5].Value = cboxRoomNo.SelectedValue.ToString();
            }
            else
            {
                gridIssueItems.Rows[n].Cells[6].Value = cboxStaff.SelectedValue.ToString();
            }

            gridIssueItems.Rows[n].Cells[7].Value = txtQty.Text;
            gridIssueItems.Rows[n].Cells[8].Value = txtrboxRemarks.Text;
            serialNo++;

            
        }

        private void issueall()
        {
            try
            {
                if (cboxStaff.Visible == false)
                {
                    for (int i = 0; i < serialNo; i++)
                    {
                        objclsIssue.issueToRoom((int.Parse(gridIssueItems.Rows[i].Cells[1].Value.ToString())), (int.Parse(gridIssueItems.Rows[i].Cells[7].Value.ToString())), (int.Parse(gridIssueItems.Rows[i].Cells[5].Value.ToString())), dateTimePickerDate.Text, (Convert.ToInt32(cmbMRno.Text)/*should be change to cmbMRno.SelectedValue.ToString()*/), txtrboxRemarks.Text, (Convert.ToInt32(txtUseriD.Text)/*should be change after hide App.Config UserValue*/));
                    }
                }
                else
                {
                    for (int i = 0; i < serialNo; i++)
                    {
                        objclsIssue.issueToStaff(int.Parse(gridIssueItems.Rows[i].Cells[1].Value.ToString()), int.Parse(gridIssueItems.Rows[i].Cells[7].Value.ToString()), int.Parse(gridIssueItems.Rows[i].Cells[6].Value.ToString()), dateTimePickerDate.Text, int.Parse(cmbMRno.Text)/*should be change to cmbMRno.SelectedValue.ToString()*/, txtrboxRemarks.Text, int.Parse(txtUseriD.Text)/*should be change after hide App.Config UserValue*/);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void cboxIssueTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxIssueTo.SelectedIndex == 0)
            {
                cboxRoomNo.Show();
                cboxDept.Show();
                lblDept.Show();
                lblRoom.Show();
                cboxStaff.Hide();
                cboxCub.Hide();
                lblCub.Hide();
                lblSatff.Hide();
            }
            else if(cboxIssueTo.SelectedIndex==1)
            {
                cboxStaff.Show();
                cboxRoomNo.Show();
                cboxCub.Show();
                cboxDept.Show();
                lblCub.Show();
                lblDept.Show();
                lblRoom.Show();
                lblSatff.Show();
 
            }
        }
        public void BindComboBoxDept()
        {
            DataTable dt = new DataTable();
            clsRegister objRegister = new clsRegister();
            dt = objRegister.SelecAlltDept();
            DataRow row = dt.NewRow();
            row["d_name"] = "Please select";
            dt.Rows.InsertAt(row, 0);
            cboxDept.DisplayMember = "d_name";
            cboxDept.ValueMember = "d_id";
            cboxDept.DataSource = dt;
        }
        public void BindComboBoxRoom()
        {
            DataTable dt = new DataTable();
            clsRegister objRegister = new clsRegister();
            dt = objRegister.SelectDeptRoom(cboxDept.SelectedValue.ToString());
            cboxRoomNo.DisplayMember = "r_name";
            cboxRoomNo.ValueMember = "r_id";
            cboxRoomNo.DataSource = dt;
        }

        private void cboxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxDept.SelectedIndex.ToString() == "0")
            {
                cboxRoomNo.Enabled = false;
                cboxCub.Enabled = false;
                cboxStaff.Enabled = false;
            }
            else
            {
               
                cboxRoomNo.Enabled = true;
                cboxCub.Enabled = true;
                cboxStaff.Enabled = true;
                BindComboBoxRoom();

            }
           
        }
        public void BindComboBoxCub()
        {
            DataTable dt2 = new DataTable();
            clsRegister objRegister = new clsRegister();
            dt2 = objRegister.SelectCub(cboxRoomNo.SelectedValue.ToString());
            cboxCub.DisplayMember = "c_name";
            cboxCub.ValueMember = "c_id";
            cboxCub.DataSource = dt2;
        }

        private void cboxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindComboBoxCub();
        }
        public void BindComboBoxStaff()
        {
            DataTable dt2 = new DataTable();
            clsRegister objRegister = new clsRegister();
            dt2 = objRegister.SelectSatff(cboxCub.SelectedValue.ToString());
            cboxStaff.DisplayMember = "s_fname";
            cboxStaff.ValueMember = "s_id";
            cboxStaff.DataSource = dt2;
        }

        private void cboxCub_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindComboBoxStaff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            issueall();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = gridIssueItems.CurrentCell.RowIndex;

                gridIssueItems.Rows.RemoveAt(selectedIndex);
                serialNo--;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void gridIssueItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
