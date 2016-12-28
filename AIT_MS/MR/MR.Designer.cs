namespace AIT_MS.MR
{
    partial class MR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnAddNewMR = new System.Windows.Forms.Button();
            this.mrGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mrGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetAll);
            this.groupBox1.Controls.Add(this.btnMain);
            this.groupBox1.Controls.Add(this.btnAddNewMR);
            this.groupBox1.Location = new System.Drawing.Point(494, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(16, 31);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 2;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(16, 139);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(100, 23);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnAddNewMR
            // 
            this.btnAddNewMR.Location = new System.Drawing.Point(16, 80);
            this.btnAddNewMR.Name = "btnAddNewMR";
            this.btnAddNewMR.Size = new System.Drawing.Size(111, 23);
            this.btnAddNewMR.TabIndex = 0;
            this.btnAddNewMR.Text = "Add New MR";
            this.btnAddNewMR.UseVisualStyleBackColor = true;
            this.btnAddNewMR.Click += new System.EventHandler(this.button1_Click);
            // 
            // mrGrid
            // 
            this.mrGrid.AllowUserToAddRows = false;
            this.mrGrid.AllowUserToDeleteRows = false;
            this.mrGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mrGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mrGrid.Location = new System.Drawing.Point(12, 26);
            this.mrGrid.Name = "mrGrid";
            this.mrGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mrGrid.Size = new System.Drawing.Size(476, 271);
            this.mrGrid.TabIndex = 1;
            this.mrGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.mrGrid_CellEndEdit);
            this.mrGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mrGrid_MouseClick);
            // 
            // MR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 360);
            this.Controls.Add(this.mrGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "MR";
            this.Text = "MR";
            this.Activated += new System.EventHandler(this.btnGetAll_Click);
            this.Load += new System.EventHandler(this.MR_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mrGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNewMR;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.DataGridView mrGrid;
    }
}