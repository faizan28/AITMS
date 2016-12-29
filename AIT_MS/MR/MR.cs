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

namespace AIT_MS.MR
{
    public partial class MR : Form
    {
        public MR()
        {
            InitializeComponent();
        }
        clsMR objclsMR = new clsMR();
        private void MR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewMR objAddNewMR = new AddNewMR();
            objAddNewMR.Show();

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.Show();
            this.Hide();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            bindMR();
        }
        private void bindMR()
        {

            DataTable dt1 = new DataTable();

            dt1 = objclsMR.getallmr();
            
            
            mrGrid.DataSource = dt1;

        }

        private void mrGrid_CellContentDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void mrGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();

              

                int currentMouseOverRow = mrGrid.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.Items.Add("Add");
                    m.Items.Add("Edit");
                    m.Items.Add("Delete");
                    //m.Items.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                   m.ItemClicked += new ToolStripItemClickedEventHandler( m_ItemClicked);
                }

                m.Show(mrGrid, new Point(e.X, e.Y));

            }
        }
        private string oldMR = "0";
        void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                
                ToolStripItem item = e.ClickedItem;
                if (item.Text == "Edit")
                {

                    oldMR = mrGrid.SelectedRows[0].Cells[0].Value.ToString();
                    mrGrid.CurrentRow.Cells[1].ReadOnly = false;
                    mrGrid.CurrentRow.Cells[0].ReadOnly = true;
                  
                  //mrGrid.Rows[0].Cells[0].ReadOnly = false;
                    mrGrid.BeginEdit(true);



                }
                else if(item.Text == "Delete")
                {
                    string mrid = mrGrid.SelectedRows[0].Cells[0].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Want to Delete that Row Permenanlty?", "Alert", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (objclsMR.deletemr(mrid) == true)
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
                    btnAddNewMR.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void mrGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newMR = mrGrid.CurrentRow.Cells[1].Value.ToString();
            //after edit code here
            if(objclsMR.updatemr(oldMR,newMR))
            {
              
            }
           
        }

        private void mrGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mrGrid.CurrentCell = mrGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            // Can leave these here - doesn't hurt
            mrGrid.Rows[e.RowIndex].Selected = true;
            mrGrid.Focus();
        }
    }
}
