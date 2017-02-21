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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
            cboxSearchFor.Items.Insert(0, "Department");
            cboxSearchFor.Items.Insert(1, "Room");
            cboxSearchFor.Items.Insert(2, "Cubical");
            cboxSearchFor.Items.Insert(3, "Staff");
            cboxSearchFor.Items.Insert(4, "Items");
            cboxSearchFor.Items.Insert(5, "Purchases");
            cboxSearchFor.Items.Insert(6, "Issues to Staff");
            cboxSearchFor.Items.Insert(7, "Issues to Room");
        }
        public void BindGrid()
        {
            try
            {
                
                dataGridView1.Refresh();
                //cboxSearch.Items.Clear();

                if (cboxSearchFor.SelectedIndex == 0)
                {
                    DataTable dt = new DataTable();
                    clsSearch objSearch = new clsSearch();
                    dt = objSearch.SelecAlltDept();
                    dataGridView1.DataSource = dt;
                    //cboxSearch.DisplayMember = "Department Name";
                    //cboxSearch.DataSource = dt;
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 600;

                }
                else if (cboxSearchFor.SelectedIndex == 1)
                {
                    DataTable dt1 = new DataTable();
                    clsSearch objSearch = new clsSearch();
                    dt1 = objSearch.SelecAllRoom();
                    dataGridView1.DataSource = dt1;
                    //cboxSearch.DisplayMember = "Room Name";
                    //cboxSearch.DataSource = dt1;
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 200;
                    dataGridView1.Columns[2].Width = 400;
                }
                else if (cboxSearchFor.SelectedIndex == 2)
                {
                    DataTable dt = new DataTable();
                    clsSearch objSearch = new clsSearch();
                    dt = objSearch.SelecAllCub();
                    //cboxSearch.DisplayMember = "Cubical Name";
                    //cboxSearch.DataSource = dt;
                    dataGridView1.DataSource = dt;

                }
                else if (cboxSearchFor.SelectedIndex == 3)
                {
                    DataTable dt = new DataTable();
                    clsSearch objSearch = new clsSearch();
                    dt = objSearch.getallstaff();
                    dataGridView1.DataSource = dt;
                    //cboxSearch.DisplayMember = "First Name";
                    //cboxSearch.DataSource = dt;
                    dataGridView1.Columns[6].Width = 200;

                }
                else if (cboxSearchFor.SelectedIndex == 4)
                {
                    DataTable dt = new DataTable();
                    clsSearch objSearch = new clsSearch();
                    dt = objSearch.getallitems();
                    dataGridView1.DataSource = dt;
                    //cboxSearch.DisplayMember = "Name";
                    //cboxSearch.DataSource = dt;
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[4].Width = 300;

                }
                else if (cboxSearchFor.SelectedIndex == 5)
                {
                    DataTable dt = new DataTable();
                    clsSearch objAddNewPurchases = new clsSearch();
                    dt = objAddNewPurchases.GetAllPurchases();
                    dataGridView1.DataSource = dt;
                    //cboxSearch.DisplayMember = "Item Name";
                    //cboxSearch.DataSource = dt;

                }
                else if (cboxSearchFor.SelectedIndex == 6)
                {
                    DataTable dt = new DataTable();
                    clsSearch objSearch = new clsSearch();
                    dt = objSearch.GetAllIssues_S();
                    dataGridView1.DataSource = dt;
                    //cboxSearch.DisplayMember = "Staff Name";
                    //cboxSearch.DataSource = dt;
                    dataGridView1.Columns[6].Width = 200;
                }
                else if (cboxSearchFor.SelectedIndex == 7)
                {
                    DataTable dt = new DataTable();
                    clsSearch objSearch = new clsSearch();
                    dt = objSearch.GetAllIssues_R();
                    dataGridView1.DataSource = dt;
                    //cboxSearch.DisplayMember = "Room";
                    //cboxSearch.DataSource = dt;
                    dataGridView1.Columns[6].Width = 200;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR"+ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            BindGrid();
           
        }
    }
}
