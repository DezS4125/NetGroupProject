namespace NetGroupProject
{
    partial class TableReservationCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.gbID = new System.Windows.Forms.GroupBox();
            this.gbID.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(16, 28);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(93, 16);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Table Name";
            this.lblTableName.Click += new System.EventHandler(this.lblTableName_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(8, 73);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(107, 23);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Check Reservation";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // gbID
            // 
            this.gbID.Controls.Add(this.btnReserve);
            this.gbID.Controls.Add(this.lblTableName);
            this.gbID.Location = new System.Drawing.Point(14, 16);
            this.gbID.Name = "gbID";
            this.gbID.Size = new System.Drawing.Size(125, 112);
            this.gbID.TabIndex = 2;
            this.gbID.TabStop = false;
            this.gbID.Text = "groupBox1";
            // 
            // TableReservationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.gbID);
            this.Name = "TableReservationCard";
            this.Size = new System.Drawing.Size(150, 141);
            this.gbID.ResumeLayout(false);
            this.gbID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTableName;
        public System.Windows.Forms.Button btnReserve;
        public System.Windows.Forms.GroupBox gbID;
    }
}
