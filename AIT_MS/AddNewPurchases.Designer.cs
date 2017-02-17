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
            this.pGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectMH = new System.Windows.Forms.Label();
            this.lblEnterItemName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPo_no = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleterow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pGridView)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name (Hide This)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PO Number (MAKE IT AUTO)";
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
            this.txtUsername.Location = new System.Drawing.Point(297, 14);
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
            // pGridView
            // 
            this.pGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.pGridView.Location = new System.Drawing.Point(61, 216);
            this.pGridView.Name = "pGridView";
            this.pGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pGridView.Size = new System.Drawing.Size(919, 150);
            this.pGridView.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S_No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "i_id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "mh_name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "h_name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "i_name";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Purchase Order No";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Quantity";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total Price";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Remarks";
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(887, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(61, 187);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(859, 62);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(121, 20);
            this.txtSupplier.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(799, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Suppiler";
            // 
            // cmbPo_no
            // 
            this.cmbPo_no.FormattingEnabled = true;
            this.cmbPo_no.Location = new System.Drawing.Point(559, 18);
            this.cmbPo_no.Name = "cmbPo_no";
            this.cmbPo_no.Size = new System.Drawing.Size(121, 21);
            this.cmbPo_no.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "addnewmr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDeleterow
            // 
            this.btnDeleterow.BackColor = System.Drawing.Color.Brown;
            this.btnDeleterow.Location = new System.Drawing.Point(176, 187);
            this.btnDeleterow.Name = "btnDeleterow";
            this.btnDeleterow.Size = new System.Drawing.Size(75, 23);
            this.btnDeleterow.TabIndex = 30;
            this.btnDeleterow.Text = "Delete";
            this.btnDeleterow.UseVisualStyleBackColor = false;
            this.btnDeleterow.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddNewPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 378);
            this.Controls.Add(this.btnDeleterow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbPo_no);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEnterItemName);
            this.Controls.Add(this.lblSelectMH);
            this.Controls.Add(this.pGridView);
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
            this.Controls.Add(this.CboxItem);
            this.Name = "AddNewPurchases";
            this.Text = "AddNewPurchases";
            this.Load += new System.EventHandler(this.AddNewPurchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxItem;
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
        private System.Windows.Forms.DataGridView pGridView;
        private System.Windows.Forms.Label lblSelectMH;
        private System.Windows.Forms.Label lblEnterItemName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPo_no;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleterow;
    }
}