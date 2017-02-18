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

namespace AIT_MS
{
    public partial class NewWirteOff : Form
    {
        public NewWirteOff()
        {
            InitializeComponent();
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

        private void NewWirteOff_Load(object sender, EventArgs e)
        {
            cboxH.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxWriteoffTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCub.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            
            bindmasterheadnames();
            cboxH.Enabled = false;
            cboxItem.Enabled = false;
            lblEnterItemName.Visible = false;
            lblSelectMH.Visible = false;

            cboxWriteoffTo.Items.Insert(0, "Room");
            cboxWriteoffTo.Items.Insert(1, "Staff");

            cmbStatus.Items.Insert(0, "Pending");
            cmbStatus.Items.Insert(1, "Done");

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

            txtUseriD.Text = Properties.Settings.Default["UserID"].ToString();
            txtUseriD.Enabled = false;


            dateTimePickerDate.Enabled = false;
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

        private void cboxDept_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cboxWriteoffTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxWriteoffTo.SelectedIndex == 0)
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
            else if (cboxWriteoffTo.SelectedIndex == 1)
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
    }

}
