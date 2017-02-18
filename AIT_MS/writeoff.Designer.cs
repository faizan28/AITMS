namespace AIT_MS
{
    partial class writeoff
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
            this.btnNewWriteOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewWriteOff
            // 
            this.btnNewWriteOff.Location = new System.Drawing.Point(302, 80);
            this.btnNewWriteOff.Name = "btnNewWriteOff";
            this.btnNewWriteOff.Size = new System.Drawing.Size(75, 23);
            this.btnNewWriteOff.TabIndex = 0;
            this.btnNewWriteOff.Text = "Add New";
            this.btnNewWriteOff.UseVisualStyleBackColor = true;
            this.btnNewWriteOff.Click += new System.EventHandler(this.btnNewWriteOff_Click);
            // 
            // writeoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 423);
            this.Controls.Add(this.btnNewWriteOff);
            this.Name = "writeoff";
            this.Text = "writeoff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewWriteOff;
    }
}