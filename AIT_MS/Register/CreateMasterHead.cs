﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using AIT_MS.App_Code;

namespace AIT_MS
{
    public partial class addmasterhead : Form
    {
        public addmasterhead()
        {
            InitializeComponent();
        }
        clsRegister objRegister = new clsRegister();
        private void addmasterhead_Load(object sender, EventArgs e)
        {
            lblEnterHead.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (masterHeadBox.Text == "")
                {
                    lblEnterHead.Visible = true;
                }
                else
                {
                  
                   if (objRegister.createMasterHead(masterHeadBox.Text) == true)
                   {
                       this.Close();
                       //here last form will open
                      
                   }                 
                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void masterHeadBox_TextChanged(object sender, EventArgs e)
        {
            lblEnterHead.Visible = false;
        }
    }
}
