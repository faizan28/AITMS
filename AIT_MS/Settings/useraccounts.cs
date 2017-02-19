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

namespace AIT_MS.Settings
{
    public partial class useraccounts : Form
    {
        public useraccounts()
        {
            InitializeComponent();
        }
        
        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            Register.CreateUser objCreateNewUser = new Register.CreateUser();
            objCreateNewUser.Show();
           
        }
        clsCreateNewUser objCreateNewUser = new clsCreateNewUser();
        private void btnGetAllUsers_Click(object sender, EventArgs e)
        {
            funcgetallusers();
        }

        private void funcgetallusers()
        {
            try
            {
                DataTable dt1 = new System.Data.DataTable();
                dt1 = objCreateNewUser.getallusers();
                GridAllUser.DataSource = dt1;

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.Show();
            this.Hide();
        }

        private void useraccounts_Load(object sender, EventArgs e)
        {

        }

        private void useraccounts_Enter(object sender, EventArgs e)
        {
            funcgetallusers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR:" + ex.Message);
            }
        }
        private void GridAllUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();



                int currentMouseOverRow = GridAllUser.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.Items.Add("Add");
                    m.Items.Add("Edit");
                    m.Items.Add("Delete");
                    //m.Items.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                    m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
                }

                m.Show(GridAllUser, new Point(e.X, e.Y));

            }
        }
        private string oldid = "0";
        void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {

                ToolStripItem item = e.ClickedItem;
                if (item.Text == "Edit")
                {

                    oldid = GridAllUser.SelectedRows[0].Cells[0].Value.ToString();
                    GridAllUser.CurrentRow.Cells[1].ReadOnly = false;
                    GridAllUser.CurrentRow.Cells[2].ReadOnly = false;
                    GridAllUser.CurrentRow.Cells[0].ReadOnly = true;

                    //GridAllUser.Rows[0].Cells[0].ReadOnly = false;
                    GridAllUser.BeginEdit(true);



                }
                else if (item.Text == "Delete")
                {
                    string oldid = GridAllUser.SelectedRows[0].Cells[0].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Want to Delete that Row Permenanlty?", "Alert", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (objCreateNewUser.deleteuser(oldid) == true)
                        {
                            //newcomment
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }


                }
                else if (item.Text == "Add")
                {
                    btnCreateForm.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void GridAllUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newusername = GridAllUser.CurrentRow.Cells[1].Value.ToString();
            string newuserpass = GridAllUser.CurrentRow.Cells[2].Value.ToString();
            //after edit code here
            if (objCreateNewUser.updateuser(oldid,newusername,newuserpass))
            {

            }

        }

        private void GridAllUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridAllUser.CurrentCell = GridAllUser.Rows[e.RowIndex].Cells[e.ColumnIndex];
            // Can leave these here - doesn't hurt
            GridAllUser.Rows[e.RowIndex].Selected = true;
            GridAllUser.Focus();
        }
    }
}
