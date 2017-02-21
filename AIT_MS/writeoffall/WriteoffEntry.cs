using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_MS.writeoffall
{
    public partial class WriteoffEntry : Form
    {
        public WriteoffEntry()
        {
            InitializeComponent();

        }
     
        public WriteoffEntry(string doi,string mr_no,string isr_id, string d_name, string r_name, string mh_name, string h_name, string i_name, string isr_qty,string remarks,string u_name)
        {
            InitializeComponent();
            txtDOI.Text = doi;
            txtMrNo.Text = mr_no;
            txtIssueID.Text = isr_id;
           
            
            txtDept.Text = d_name;
            txtRoomNo.Text = r_name;
            
            txtMH.Text = mh_name;
            txtH.Text = h_name;
            txtItemName.Text = i_name;
            txtIqty.Text = isr_qty;
            txtrRemarks.Text = remarks;
            txtuser.Text = u_name;

        }
        public WriteoffEntry(string doi, string mr_no, string isr_id, string d_name, string r_name, string mh_name, string h_name, string i_name, string isr_qty, string remarks, string u_name,string c_no,string f_name)
        {
            InitializeComponent();
            txtDOI.Text = doi;
            txtMrNo.Text = mr_no;
            txtIssueID.Text = isr_id;


            txtDept.Text = d_name;
            txtRoomNo.Text = r_name;

            txtMH.Text = mh_name;
            txtH.Text = h_name;
            txtItemName.Text = i_name;
            txtIqty.Text = isr_qty;
            txtrRemarks.Text = remarks;
            txtuser.Text = u_name;
            txtCub.Text = c_no;
            txtStaff.Text = f_name;

        }
        private void WriteoffEntry_Load(object sender, EventArgs e)
        {
            dTPwoed.Value = DateTime.Now;
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
