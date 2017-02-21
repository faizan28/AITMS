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
       

        private void bindItems()
        {
            clsNewWriteOff objNewWriteOff = new clsNewWriteOff();
            DataTable dt = new DataTable();
            if (cboxWriteoffTo.SelectedIndex.ToString() == "0")
            {
                
                dt = objNewWriteOff.GetAllRoomIssues(cboxRoomNo.SelectedValue.ToString());
                cboxItem.DisplayMember = "i_name";
                cboxItem.ValueMember = "i_id";
                cboxItem.DataSource = dt;

            }
           else if (cboxWriteoffTo.SelectedIndex.ToString() == "1")
            {
                dt = objNewWriteOff.GetAllStaffIssues(cboxStaff.SelectedValue.ToString());
                cboxItem.DisplayMember = "i_name";
                cboxItem.ValueMember = "i_id";
                cboxItem.DataSource = dt;
                

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

        private void NewWirteOff_Load(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = DateTime.Now;
            
            cboxWriteoffTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCub.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;


            cboxItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxItem.DropDownStyle = ComboBoxStyle.DropDownList;
            

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
            DataRow row = dt.NewRow();
            row["r_name"] = "Please select";
            dt.Rows.InsertAt(row, 0);
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
            DataRow row = dt2.NewRow();
            row["c_name"] = "Please select";
            dt2.Rows.InsertAt(row, 0);
            cboxCub.DisplayMember = "c_name";
            cboxCub.ValueMember = "c_id";
            cboxCub.DataSource = dt2;
        }
        private void cboxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboxWriteoffTo.SelectedIndex.ToString() == "0")
            //{
            //    bindItems();
               
            //}
            BindComboBoxCub();
        }
        public void BindComboBoxStaff()
        {
            DataTable dt2 = new DataTable();
            clsRegister objRegister = new clsRegister();
            dt2 = objRegister.SelectSatff(cboxCub.SelectedValue.ToString());
            DataRow row = dt2.NewRow();
            row["s_fname"] = "Please select";
            dt2.Rows.InsertAt(row, 0);
            cboxStaff.DisplayMember = "s_fname";
            cboxStaff.ValueMember = "s_id";
            cboxStaff.DataSource = dt2;
        }
        private void cboxCub_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindComboBoxStaff();
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

        private void cboxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bindItems();
            
        }
        public void bindgrid()
        {
            
            if (cboxWriteoffTo.SelectedIndex == 0 && cboxRoomNo.SelectedIndex ==0 && cboxDept.SelectedIndex!=0)
            {
                DataTable dt = new DataTable();
                clsNewWriteOff objNewWriteOff = new clsNewWriteOff();
                dt = objNewWriteOff.GetAllDeptRoomIssuesGrid(cboxDept.SelectedValue.ToString());
                gridWriteoff.DataSource = dt;
            }
            else if (cboxWriteoffTo.SelectedIndex == 0 && cboxDept.SelectedIndex != 0 && cboxRoomNo.SelectedIndex != 0)
            {
                DataTable dt = new DataTable();
                clsNewWriteOff objNewWriteOff = new clsNewWriteOff();
                dt = objNewWriteOff.GetAllRoomIssuesGrid(cboxRoomNo.SelectedValue.ToString());
                gridWriteoff.DataSource = dt;
 
            }
            else if (cboxWriteoffTo.SelectedIndex == 1 && cboxDept.SelectedIndex != 0 && cboxRoomNo.SelectedIndex == 0 && cboxCub.SelectedIndex == 0 && cboxStaff.SelectedIndex == 0)
            {
                DataTable dt = new DataTable();
                clsNewWriteOff objNewWriteOff = new clsNewWriteOff();
                dt = objNewWriteOff.GetAllDeptStaffIssuesGrid(cboxDept.SelectedValue.ToString());
                gridWriteoff.DataSource = dt;

            }
            else if (cboxWriteoffTo.SelectedIndex == 1 && cboxDept.SelectedIndex != 0 && cboxRoomNo.SelectedIndex != 0 && cboxCub.SelectedIndex == 0 && cboxStaff.SelectedIndex == 0)
            {
                DataTable dt = new DataTable();
                clsNewWriteOff objNewWriteOff = new clsNewWriteOff();
                dt = objNewWriteOff.GetAllRoomStaffIssuesGrid(cboxRoomNo.SelectedValue.ToString());
                gridWriteoff.DataSource = dt;

            }
            else if (cboxWriteoffTo.SelectedIndex == 1 && cboxDept.SelectedIndex != 0 && cboxRoomNo.SelectedIndex != 0 && cboxCub.SelectedIndex != 0 && cboxStaff.SelectedIndex == 0)
            {
                DataTable dt = new DataTable();
                clsNewWriteOff objNewWriteOff = new clsNewWriteOff();
                dt = objNewWriteOff.GetAllCubicalStaffIssuesGrid(cboxCub.SelectedValue.ToString());
                gridWriteoff.DataSource = dt;

            }
            else if (cboxWriteoffTo.SelectedIndex == 1 && cboxDept.SelectedIndex != 0 && cboxRoomNo.SelectedIndex != 0 && cboxCub.SelectedIndex != 0 && cboxStaff.SelectedIndex != 0)
            {
                DataTable dt = new DataTable();
                clsNewWriteOff objNewWriteOff = new clsNewWriteOff();
                dt = objNewWriteOff.GetAllStaffIssuesGrid(cboxStaff.SelectedValue.ToString());
                gridWriteoff.DataSource = dt;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindgrid();
        }

        private void gridWriteoff_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (cboxCub.Enabled == false)
                {
                    string isr_doi = gridWriteoff.SelectedRows[0].Cells[0].Value.ToString();
                    string mr_no = gridWriteoff.SelectedRows[0].Cells[1].Value.ToString();
                    string isr_id = gridWriteoff.SelectedRows[0].Cells[2].Value.ToString();
                    string d_name = gridWriteoff.SelectedRows[0].Cells[3].Value.ToString();
                    string r_name = gridWriteoff.SelectedRows[0].Cells[4].Value.ToString();
                    string mh_name = gridWriteoff.SelectedRows[0].Cells[5].Value.ToString();
                    string h_name = gridWriteoff.SelectedRows[0].Cells[6].Value.ToString();
                    string i_name = gridWriteoff.SelectedRows[0].Cells[7].Value.ToString();
                    string isr_qty = gridWriteoff.SelectedRows[0].Cells[8].Value.ToString();
                    string remarks = gridWriteoff.SelectedRows[0].Cells[9].Value.ToString();
                    string u_name = gridWriteoff.SelectedRows[0].Cells[10].Value.ToString();
                    writeoffall.WriteoffEntry objWriteoffEntry = new writeoffall.WriteoffEntry(isr_doi, mr_no, isr_id, d_name, r_name, mh_name, h_name, i_name, isr_qty, remarks, u_name);
                    objWriteoffEntry.Show();
                }
                else
                {
                    string isr_doi = gridWriteoff.SelectedRows[0].Cells[0].Value.ToString();
                    string mr_no = gridWriteoff.SelectedRows[0].Cells[1].Value.ToString();
                    string isr_id = gridWriteoff.SelectedRows[0].Cells[2].Value.ToString();
                    string d_name = gridWriteoff.SelectedRows[0].Cells[3].Value.ToString();
                    string r_name = gridWriteoff.SelectedRows[0].Cells[4].Value.ToString();
                    string c_no = gridWriteoff.SelectedRows[0].Cells[5].Value.ToString();;
                    string f_name = gridWriteoff.SelectedRows[0].Cells[6].Value.ToString(); ;
                    string mh_name = gridWriteoff.SelectedRows[0].Cells[7].Value.ToString();
                    string h_name = gridWriteoff.SelectedRows[0].Cells[8].Value.ToString();
                    string i_name = gridWriteoff.SelectedRows[0].Cells[9].Value.ToString();
                    string isr_qty = gridWriteoff.SelectedRows[0].Cells[10].Value.ToString();
                    string remarks = gridWriteoff.SelectedRows[0].Cells[11].Value.ToString();
                    string u_name = gridWriteoff.SelectedRows[0].Cells[12].Value.ToString();
                    writeoffall.WriteoffEntry objWriteoffEntry = new writeoffall.WriteoffEntry(isr_doi, mr_no, isr_id, d_name, r_name, mh_name, h_name, i_name, isr_qty, remarks, u_name,c_no,f_name);
                    objWriteoffEntry.Show();
                
 
                }
                //edit ed = new edit(id)
                //ed.Show();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("ERROR:"+ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt1;
                dt1 = null;
                gridWriteoff.DataSource = dt1;
                
        
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR:" + ex.Message);
            }
        }
    }

}
