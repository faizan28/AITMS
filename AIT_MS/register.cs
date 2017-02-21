using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIT_MS.Register;
using AIT_MS.App_Code;
namespace AIT_MS
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addmasterhead objAddMasterHead = new addmasterhead();
            objAddMasterHead.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addhead objAddHead = new addhead();
            objAddHead.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItem objAddItem = new AddItem();
            objAddItem.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CreateStaff objCreateStaff = new CreateStaff();
            objCreateStaff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateDept objCreateDept = new CreateDept();
            objCreateDept.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateRoom objCreateRoom = new CreateRoom();
            objCreateRoom.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateCub objCreateCub = new CreateCub();
            objCreateCub.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.Show();
            this.Hide();
        }

        private void register_Load(object sender, EventArgs e)
        {
          
                
           



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void itemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadItem();
        }

        private void loadItem()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();
            dt = obj.getallitems();
            itemsGridView.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadStaff();
        }

        private void loadStaff()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();
            dt = obj.getallstaff();
            StaffGridView.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadHeadMaster();
        }
        private void loadHeadMaster()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();

            dt = obj.loadmhheadnames();
            HeadGridView.DataSource = dt;
        }

       



        private void btnViewDept_Click(object sender, EventArgs e)
        {
            lbl.Text = "All Departments";
            GetAllDepartments();
            lblDeptRooms.Text = "All Depts";
        }

        private void GetAllDepartments()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();

            dt = obj.SelecAlltDept();
            DeptRoomGrid.DataSource = dt;
        }

        private void GetAllHead_MasrerHead()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();

            dt = obj.getallHeadAndMasterHead();
            HeadGridView.DataSource = dt;

           
        }

        //private void btnViewAll_Click(object sender, EventArgs e)
        //{
        //    GetAllDept_room_cubical();
        //}

        //private void GetAllDept_room_cubical()
        //{
        //    clsRegister obj = new clsRegister();
        //    DataTable dt = new DataTable();
        //    dt = obj.
        //    DeptRoomGrid.DataSource = dt;
        //}

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            GetAllRooms();
            lblDeptRooms.Text = "All Rooms";
        }



        private void GetAllRooms()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();
            dt = obj.getallRoom();
            DeptRoomGrid.DataSource = dt;
        }

        private void GetAllCubical()
        {
            clsRegister obj = new clsRegister();
            DataTable dt = new DataTable();
            dt = obj.getallCubical_room();
            DeptRoomGrid.DataSource = dt;
        }

        private void btnViewCubical_Click(object sender, EventArgs e)
        {
            GetAllCubical();
            lblDeptRooms.Text = "All Cubicles";
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            GetAllHead_MasrerHead();
        }



        //private void mrGrid_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        ContextMenuStrip m = new ContextMenuStrip();



        //        int currentMouseOverRow = itemsGridView.HitTest(e.X, e.Y).RowIndex;

        //        if (currentMouseOverRow >= 0)
        //        {
        //            m.Items.Add("Add");
        //            m.Items.Add("Edit");
        //            m.Items.Add("Delete");
        //            //m.Items.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
        //            m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
        //        }

        //        m.Show(itemsGridView, new Point(e.X, e.Y));

        //    }
        //}
        //private string oldMR = "0";
        //void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    try
        //    {

        //        ToolStripItem item = e.ClickedItem;
        //        if (item.Text == "Edit")
        //        {

        //            oldMR = itemsGridView.SelectedRows[0].Cells[0].Value.ToString();
        //            itemsGridView.CurrentRow.Cells[0].ReadOnly = false;
        //            itemsGridView.CurrentRow.Cells[1].ReadOnly = false;
        //            itemsGridView.CurrentRow.Cells[2].ReadOnly = false;
        //            itemsGridView.CurrentRow.Cells[3].ReadOnly = true;
        //            itemsGridView.CurrentRow.Cells[4].ReadOnly = true;

        //            //itemsGridView.Rows[0].Cells[0].ReadOnly = false;
        //            itemsGridView.BeginEdit(true);



        //        }
        //        else if (item.Text == "Delete")
        //        {
        //            string name = itemsGridView.SelectedRows[0].Cells[0].Value.ToString();
                    
        //            DialogResult dialogResult = MessageBox.Show("Want to Delete that Row Permenanlty?", "Alert", MessageBoxButtons.YesNo);
        //            if (dialogResult == DialogResult.Yes)
        //            {
        //                clsRegister objregister = new clsRegister();
        //                if (objregister.dltItem(name) == true)
        //                {
        //                    //newcomment
        //                }
        //            }
        //            else if (dialogResult == DialogResult.No)
        //            {
        //                //do something else
        //            }


        //        }
        //        else if (item.Text == "Add")
        //        {
        //            button3.PerformClick();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR:" + ex.Message);
        //    }
        //}

        //private void mrGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    string newMR = itemsGridView.CurrentRow.Cells[1].Value.ToString();
        //    //after edit code here
        //    if (objclsMR.updatemr(oldMR, newMR))
        //    {

        //    }

        //}

        //private void mrGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    itemsGridView.CurrentCell = itemsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //    // Can leave these here - doesn't hurt
        //    itemsGridView.Rows[e.RowIndex].Selected = true;
        //    itemsGridView.Focus();
        //}







    }
}
