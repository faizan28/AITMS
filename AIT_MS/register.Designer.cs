namespace AIT_MS
{
    partial class register
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffGridView = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnViewCubical = new System.Windows.Forms.Button();
            this.btnViewRooms = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.DeptRoomGrid = new System.Windows.Forms.DataGridView();
            this.btnViewDept = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnHead = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.HeadGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblDeptRooms = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptRoomGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.itemsGridView);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(834, 85);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "View Items";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "All Items";
            // 
            // itemsGridView
            // 
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.itemsGridView.Location = new System.Drawing.Point(171, 108);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGridView.Size = new System.Drawing.Size(516, 150);
            this.itemsGridView.TabIndex = 3;
            this.itemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(834, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.StaffGridView);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Staff";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(391, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "All Staff";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StaffGridView
            // 
            this.StaffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGridView.Location = new System.Drawing.Point(178, 107);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.Size = new System.Drawing.Size(570, 150);
            this.StaffGridView.TabIndex = 5;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(884, 107);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "View Staff";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(884, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Add Staff";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblDeptRooms);
            this.tabPage3.Controls.Add(this.btnViewCubical);
            this.tabPage3.Controls.Add(this.btnViewRooms);
            this.tabPage3.Controls.Add(this.lbl);
            this.tabPage3.Controls.Add(this.DeptRoomGrid);
            this.tabPage3.Controls.Add(this.btnViewDept);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dept/Rooms";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnViewCubical
            // 
            this.btnViewCubical.Location = new System.Drawing.Point(867, 201);
            this.btnViewCubical.Name = "btnViewCubical";
            this.btnViewCubical.Size = new System.Drawing.Size(84, 23);
            this.btnViewCubical.TabIndex = 11;
            this.btnViewCubical.Text = "View Cubical";
            this.btnViewCubical.UseVisualStyleBackColor = true;
            this.btnViewCubical.Click += new System.EventHandler(this.btnViewCubical_Click);
            // 
            // btnViewRooms
            // 
            this.btnViewRooms.Location = new System.Drawing.Point(867, 142);
            this.btnViewRooms.Name = "btnViewRooms";
            this.btnViewRooms.Size = new System.Drawing.Size(84, 23);
            this.btnViewRooms.TabIndex = 10;
            this.btnViewRooms.Text = "View Rooms";
            this.btnViewRooms.UseVisualStyleBackColor = true;
            this.btnViewRooms.Click += new System.EventHandler(this.btnViewRooms_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(182, 40);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 8;
            // 
            // DeptRoomGrid
            // 
            this.DeptRoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptRoomGrid.Location = new System.Drawing.Point(185, 102);
            this.DeptRoomGrid.Name = "DeptRoomGrid";
            this.DeptRoomGrid.Size = new System.Drawing.Size(478, 150);
            this.DeptRoomGrid.TabIndex = 7;
            // 
            // btnViewDept
            // 
            this.btnViewDept.Location = new System.Drawing.Point(867, 84);
            this.btnViewDept.Name = "btnViewDept";
            this.btnViewDept.Size = new System.Drawing.Size(84, 23);
            this.btnViewDept.TabIndex = 6;
            this.btnViewDept.Text = "View Dept";
            this.btnViewDept.UseVisualStyleBackColor = true;
            this.btnViewDept.Click += new System.EventHandler(this.btnViewDept_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(867, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Add Cubicle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(867, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add Room";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(867, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Dept";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnHead);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.HeadGridView);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(976, 562);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Heads";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnHead
            // 
            this.btnHead.Location = new System.Drawing.Point(814, 135);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(108, 23);
            this.btnHead.TabIndex = 7;
            this.btnHead.Text = "View Head";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(814, 77);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "View Master Head";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // HeadGridView
            // 
            this.HeadGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HeadGridView.Location = new System.Drawing.Point(95, 123);
            this.HeadGridView.Name = "HeadGridView";
            this.HeadGridView.Size = new System.Drawing.Size(568, 176);
            this.HeadGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(237, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heads And MasterHead";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Head";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Master Head";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(863, 33);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblDeptRooms
            // 
            this.lblDeptRooms.AutoSize = true;
            this.lblDeptRooms.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDeptRooms.Location = new System.Drawing.Point(371, 59);
            this.lblDeptRooms.Name = "lblDeptRooms";
            this.lblDeptRooms.Size = new System.Drawing.Size(113, 21);
            this.lblDeptRooms.TabIndex = 12;
            this.lblDeptRooms.Text = "Dept/Rooms";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.tabControl1);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptRoomGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StaffGridView;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView HeadGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewDept;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView DeptRoomGrid;
        private System.Windows.Forms.Button btnViewRooms;
        private System.Windows.Forms.Button btnViewCubical;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.Label lblDeptRooms;
    }
}