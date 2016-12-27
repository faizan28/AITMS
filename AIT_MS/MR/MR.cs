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

        private void mrGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
         

        }

        private void mrGrid_CellContentDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                String id = mrGrid.SelectedCells[0].Value.ToString();
             
                AddNewMR objAddNewMR = new AddNewMR(int.Parse(id));
                objAddNewMR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:"+ex.Message);
            }
        }
    }
}
