﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIT_MS
{
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewPurchases objAddNewPurchases = new AddNewPurchases();
           
            objAddNewPurchases.Show();
            this.Hide();

        }
    }
}
