namespace AIT_MS
{
    partial class AddNewPurchases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CboxItem = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTprice = new System.Windows.Forms.TextBox();
            this.rtxtremarks = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerToday = new System.Windows.Forms.DateTimePicker();
            this.cboxMh = new System.Windows.Forms.ComboBox();
            this.CboxH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSelectMH = new System.Windows.Forms.Label();
            this.lblEnterItemName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboxItem
            // 
            this.CboxItem.FormattingEnabled = true;
            this.CboxItem.Location = new System.Drawing.Point(487, 156);
            this.CboxItem.Name = "CboxItem";
            this.CboxItem.Size = new System.Drawing.Size(274, 21);
            this.CboxItem.TabIndex = 0;
            this.CboxItem.SelectedIndexChanged += new System.EventHandler(this.CboxItem_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(780, 15);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPurchaseDate.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(859, 98);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtTprice
            // 
            this.txtTprice.Location = new System.Drawing.Point(859, 156);
            this.txtTprice.Name = "txtTprice";
            this.txtTprice.Size = new System.Drawing.Size(121, 20);
            this.txtTprice.TabIndex = 5;
            // 
            // rtxtremarks
            // 
            this.rtxtremarks.Location = new System.Drawing.Point(61, 51);
            this.rtxtremarks.Name = "rtxtremarks";
            this.rtxtremarks.Size = new System.Drawing.Size(270, 125);
            this.rtxtremarks.TabIndex = 6;
            this.rtxtremarks.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PO Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Purchase Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(787, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Price";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(269, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(62, 20);
            this.txtUsername.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Remarks";
            // 
            // dateTimePickerToday
            // 
            this.dateTimePickerToday.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerToday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToday.Location = new System.Drawing.Point(61, 15);
            this.dateTimePickerToday.Name = "dateTimePickerToday";
            this.dateTimePickerToday.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerToday.TabIndex = 16;
            // 
            // cboxMh
            // 
            this.cboxMh.FormattingEnabled = true;
            this.cboxMh.Location = new System.Drawing.Point(487, 62);
            this.cboxMh.Name = "cboxMh";
            this.cboxMh.Size = new System.Drawing.Size(121, 21);
            this.cboxMh.TabIndex = 17;
            this.cboxMh.SelectedIndexChanged += new System.EventHandler(this.cboxMh_SelectedIndexChanged);
            // 
            // CboxH
            // 
            this.CboxH.FormattingEnabled = true;
            this.CboxH.Location = new System.Drawing.Point(487, 107);
            this.CboxH.Name = "CboxH";
            this.CboxH.Size = new System.Drawing.Size(121, 21);
            this.CboxH.TabIndex = 18;
            this.CboxH.SelectedIndexChanged += new System.EventHandler(this.CboxH_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Master Head";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Head";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // lblSelectMH
            // 
            this.lblSelectMH.AutoSize = true;
            this.lblSelectMH.ForeColor = System.Drawing.Color.Red;
            this.lblSelectMH.Location = new System.Drawing.Point(507, 86);
            this.lblSelectMH.Name = "lblSelectMH";
            this.lblSelectMH.Size = new System.Drawing.Size(101, 13);
            this.lblSelectMH.TabIndex = 22;
            this.lblSelectMH.Text = "Select Master Head";
            // 
            // lblEnterItemName
            // 
            this.lblEnterItemName.AutoSize = true;
            this.lblEnterItemName.ForeColor = System.Drawing.Color.Red;
            this.lblEnterItemName.Location = new System.Drawing.Point(675, 180);
            this.lblEnterItemName.Name = "lblEnterItemName";
            this.lblEnterItemName.Size = new System.Drawing.Size(91, 13);
            this.lblEnterItemName.TabIndex = 23;
            this.lblEnterItemName.Text = "Select Item Name";
            // 
            // AddNewPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 378);
            this.Controls.Add(this.lblEnterItemName);
            this.Controls.Add(this.lblSelectMH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CboxH);
            this.Controls.Add(this.cboxMh);
            this.Controls.Add(this.dateTimePickerToday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtremarks);
            this.Controls.Add(this.txtTprice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dateTimePickerPurchaseDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CboxItem);
            this.Name = "AddNewPurchases";
            this.Text = "AddNewPurchases";
            this.Load += new System.EventHandler(this.AddNewPurchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTprice;
        private System.Windows.Forms.RichTextBox rtxtremarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerToday;
        private System.Windows.Forms.ComboBox cboxMh;
        private System.Windows.Forms.ComboBox CboxH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSelectMH;
        private System.Windows.Forms.Label lblEnterItemName;
    }
}