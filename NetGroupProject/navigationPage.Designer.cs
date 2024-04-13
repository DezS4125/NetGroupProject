namespace NetGroupProject
{
    partial class navigationPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRevenueStatistic = new System.Windows.Forms.Button();
            this.btnTableReservation = new System.Windows.Forms.Button();
            this.btnInvoiceManagement = new System.Windows.Forms.Button();
            this.btnMenuManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.groupProjectDataSet1 = new NetGroupProject.groupProjectDataSet();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "A Restaurant Management System!";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(188, 76);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(183, 18);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome back, {name}";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(17, 16);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(552, 255);
            this.txtLog.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLog);
            this.groupBox2.Location = new System.Drawing.Point(185, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 284);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History log";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnRevenueStatistic);
            this.groupBox1.Controls.Add(this.btnTableReservation);
            this.groupBox1.Controls.Add(this.btnInvoiceManagement);
            this.groupBox1.Controls.Add(this.btnMenuManagement);
            this.groupBox1.Controls.Add(this.btnUserManagement);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 50, 3, 10);
            this.groupBox1.Size = new System.Drawing.Size(161, 450);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation Bar";
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(3, 417);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRevenueStatistic
            // 
            this.btnRevenueStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevenueStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenueStatistic.Location = new System.Drawing.Point(3, 164);
            this.btnRevenueStatistic.Name = "btnRevenueStatistic";
            this.btnRevenueStatistic.Size = new System.Drawing.Size(155, 23);
            this.btnRevenueStatistic.TabIndex = 4;
            this.btnRevenueStatistic.Text = "Revenue statistic";
            this.btnRevenueStatistic.UseVisualStyleBackColor = true;
            this.btnRevenueStatistic.Click += new System.EventHandler(this.btnRevenueStatistic_Click);
            // 
            // btnTableReservation
            // 
            this.btnTableReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTableReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableReservation.Location = new System.Drawing.Point(3, 141);
            this.btnTableReservation.Name = "btnTableReservation";
            this.btnTableReservation.Size = new System.Drawing.Size(155, 23);
            this.btnTableReservation.TabIndex = 3;
            this.btnTableReservation.Text = "Table Reservation";
            this.btnTableReservation.UseVisualStyleBackColor = true;
            this.btnTableReservation.Click += new System.EventHandler(this.btnTableReservation_Click);
            // 
            // btnInvoiceManagement
            // 
            this.btnInvoiceManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoiceManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceManagement.Location = new System.Drawing.Point(3, 118);
            this.btnInvoiceManagement.Name = "btnInvoiceManagement";
            this.btnInvoiceManagement.Size = new System.Drawing.Size(155, 23);
            this.btnInvoiceManagement.TabIndex = 2;
            this.btnInvoiceManagement.Text = "Invoice Management";
            this.btnInvoiceManagement.UseVisualStyleBackColor = true;
            this.btnInvoiceManagement.Click += new System.EventHandler(this.btnInvoiceManagement_Click);
            // 
            // btnMenuManagement
            // 
            this.btnMenuManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManagement.Location = new System.Drawing.Point(3, 95);
            this.btnMenuManagement.Name = "btnMenuManagement";
            this.btnMenuManagement.Size = new System.Drawing.Size(155, 23);
            this.btnMenuManagement.TabIndex = 1;
            this.btnMenuManagement.Text = "Menu Management";
            this.btnMenuManagement.UseVisualStyleBackColor = true;
            this.btnMenuManagement.Click += new System.EventHandler(this.btnMenuManagement_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(3, 72);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(155, 23);
            this.btnUserManagement.TabIndex = 0;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // groupProjectDataSet1
            // 
            this.groupProjectDataSet1.DataSetName = "groupProjectDataSet";
            this.groupProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // navigationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label1);
            this.Name = "navigationPage";
            this.Text = "navigationPage";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRevenueStatistic;
        private System.Windows.Forms.Button btnTableReservation;
        private System.Windows.Forms.Button btnInvoiceManagement;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private groupProjectDataSet groupProjectDataSet1;
    }
}